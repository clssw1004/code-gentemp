using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class TemplateFactory
    {
        private static Dictionary<String, String> global_templates = new Dictionary<string, string>();

        public static T GetTemplate<T>(String tpName) where T : Template
        {
            String tplStr = global_templates[tpName];
            return (T)System.Activator.CreateInstance(typeof(T),tplStr);

        }

        public static void Register(String tplName,String tplContent)
        {
            global_templates.Add(tplName, tplContent);
        }
    }
}
