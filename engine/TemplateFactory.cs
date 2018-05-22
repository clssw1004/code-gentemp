using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace engine
{
    public class TemplateFactory
    {
        static TemplateFactory()
        {
            RefreshResources();
        }
        protected static Dictionary<String, String> global_args = new Dictionary<String, String>();
        private static Dictionary<String, String> global_templates = new Dictionary<string, string>();

        public static Boolean HasArg(String key)
        {
            return global_args.ContainsKey(key);
        }
        public static String GetArg(String key)
        {
            if (HasArg(key))
            {
                return global_args[key];
            }
            return null;
        }
        public static T GetTemplate<T>(String tpName) where T : Template
        {
            if (global_templates.ContainsKey(tpName))
            {
                return (T)System.Activator.CreateInstance(typeof(T), global_templates[tpName]);
            }
            else if (global_templates.ContainsKey(tpName + ".tpl"))
            {
                return (T)System.Activator.CreateInstance(typeof(T), global_templates[tpName + ".tpl"]);
            }
            return null;
        }
        private static Template EmptyTemplate()
        {
            return new SimpleTemplate("");
        }
        public static void Register(String tplName, String tplContent)
        {
            global_templates.Add(tplName, tplContent);
        }
        public static void RefreshResources()
        {
            List<String> paths = TemplateConfig.GetPaths();
            foreach (var p in paths)
            {
                RefreshByPath(p);
            }
        }
        private static void RefreshByPath(String path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach(var si in di.GetFileSystemInfos())
            {
                if(si is DirectoryInfo)
                {
                    RefreshByPath(si.FullName);
                }
                else if(si is FileInfo)
                {

                    FileInfo fi = si as FileInfo;
                    if (Regex.IsMatch(fi.Name, @"\.json$"))
                    {
                        String json = File.ReadAllText(fi.FullName, Encoding.UTF8);
                        JObject jObject = (JObject)JsonConvert.DeserializeObject(json);
                        foreach (var t in jObject)
                        {
                            global_args.Add(t.Key, t.Value.ToString());
                        }
                    }
                    if (Regex.IsMatch(fi.Name, @"\.tpl$"))
                    {
                        String tplStr = File.ReadAllText(fi.FullName, Encoding.UTF8);
                        TemplateFactory.Register(fi.Name, tplStr);
                    }
                }
            }
        }
    }
}
