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
    public abstract class Template
    {

        protected String Content { get; set; }
        protected Template(String templateFile, Encoding encoding)
        {
            if (File.Exists(templateFile))
            {
                Content = File.ReadAllText(templateFile, encoding);
            }
        }
        protected Template(String templateStr)
        {
            Content = templateStr;
        }
        public abstract String Render(Dictionary<String, Object> args);
        
        protected static String GetValue(String variable, Dictionary<String, Object> args)
        {
            if (args.ContainsKey(variable) && args[variable] != null)
            {
                return args[variable].ToString();
            }
            else if (TemplateFactory.HasArg(variable))
            {
                return TemplateFactory.GetArg(variable);
            }
            return String.Format(" [\"{0}\" is undefined] ", variable);
        }

        protected static String GetVariable(String m, EnumGrammerType type)
        {
            String variable = m;
            switch (type)
            {
                case EnumGrammerType.ARG:
                    variable = replaceToBlank(variable, "${", "}");
                    break;
                case EnumGrammerType.INCLUDE:
                    variable = replaceToBlank(variable, "$include{", "}");
                    break;
            }
            return variable;
        }
        protected static String replaceToBlank(String src, params String[] str)
        {
            String result = src;
            if (str != null && str.Length > 0)
            {
                foreach (var p in str)
                {
                    result = result.Replace(p, "");
                }
            }
            return result;
        }
    }
}
