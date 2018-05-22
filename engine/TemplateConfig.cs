using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class TemplateConfig
    {
        private const String path = "./config.json";
        private static JObject configs = null;
        static TemplateConfig()
        {
            if (!File.Exists(path))
            {
                JObject jObject = new JObject();
                jObject.Add("templates", new JArray());
                SaveToFile(jObject);
            }
            String json = File.ReadAllText(path, Encoding.UTF8);
            configs = (JObject)JsonConvert.DeserializeObject(json);
        }

        public static void AddPath(String path)
        {
            ((JArray)configs["templates"]).Add(path);
            SaveToFile(configs);
            TemplateFactory.RefreshResources();
        }

        public static void RemovePath(int index)
        {
            //((JArray)configs["templates"]).RemoveAt(index)
            ((JArray)configs["templates"]).RemoveAt(index);
            SaveToFile(configs);
        }
        public static List<String> GetPaths()
        {
            List<String> paths = new List<string>();
            foreach(var o in (JArray)configs["templates"])
            {
                paths.Add(o.ToString());
            }
            return paths;
        }
        private static void SaveToFile(JObject jObject)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(JsonConvert.SerializeObject(jObject));
                sw.Close();
            }
        }

    }
}
