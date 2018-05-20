using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace engine
{
    public class Template
    {
        private static Dictionary<String, String> global_args = new Dictionary<String, String>();
        private static Dictionary<String, String> global_templates = new Dictionary<string, string>();
        static Template()
        {
            RefreshResources();
        }
        private String TemplateStr;
        private String Result;
        public Template(String templateFile, Encoding encoding)
        {
            if (File.Exists(templateFile))
            {
                TemplateStr = File.ReadAllText(templateFile, encoding);
            }
        }
        public Template(String templateStr)
        {
            TemplateStr = templateStr;
        }
        /// <summary>
        /// 解析模版
        /// </summary>
        /// <returns></returns>
        public String Analyze(Dictionary<String, String> args)
        {
            Result = AnalyzeVariable(TemplateStr, args);
            Result = AnalyzeTemplate(Result, args);
            return Result;
        }
        /// <summary>
        /// 解析变量
        /// </summary>
        /// <param name="tpl"></param>
        /// <returns></returns>
        private String AnalyzeVariable(String tpl, Dictionary<String, String> args)
        {
            String result = TemplateStr;
            MatchCollection mc = Regex.Matches(result, Constants.ARG_REGEX);
            foreach (Match m in mc)
            {
                String variable = GetVariable(m.Value, EnumGrammerType.ARG);
                String value = null;
                if (InternalVariable.IsInternal(variable))
                {
                    value = InternalVariable.Analyze(variable);
                }
                else
                {
                    value = GetValue(variable, args);
                }
                result = result.Replace(m.Value, value);
            }
            return result;
        }
        /// <summary>
        /// 解析include模版
        /// </summary>
        /// <param name="tpl"></param>
        /// <returns></returns>
        private String AnalyzeTemplate(String tpl, Dictionary<String, String> args)
        {
            String result = tpl;
            MatchCollection mc = Regex.Matches(result, Constants.INCLUDE_REGEX);
            foreach (Match m in mc)
            {
                String variable = GetVariable(m.Value, EnumGrammerType.INCLUDE);
                Template template = GetTemplate(variable);
                String value = null;
                if (template != null)
                {
                    value = template.Analyze(args);
                }
                else
                {
                    value = String.Format(" [can't find template \"{0}\"] ", variable);
                }
                result = result.Replace(m.Value, value);
            }
            return result;
        }
        private static String GetValue(String variable,Dictionary<String,String> args)
        {
            if (args.ContainsKey(variable))
            {
                return args[variable];
            }else if(global_args.ContainsKey(variable))
            {
                return global_args[variable];
            }
            return String.Format(" [\"{0}\" is undefined] ", variable);
        }
        private static Template GetTemplate(String tpName)
        {
            String tplStr =  global_templates[tpName];
            return new Template(tplStr);
        }
        private static String GetVariable(String m, EnumGrammerType type)
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
        private static String replaceToBlank(String src, params String[] str)
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

        public  static void RefreshResources()
        {
            List<String> paths = TemplateConfig.GetPaths();
            foreach (var p in paths)
            {
                if (Directory.Exists(p))
                {
                    foreach (var f in Directory.GetFiles(p))
                    {
                        if (Regex.IsMatch(f, @"\.json"))
                        {
                            String json = File.ReadAllText(f, Encoding.UTF8);
                            JObject jObject = (JObject)JsonConvert.DeserializeObject(json);
                            foreach (var t in jObject)
                            {
                                global_args.Add(t.Key, t.Value.ToString());
                            }
                        }
                        if (Regex.IsMatch(f, @"\.tpl"))
                        {
                            String tplStr = File.ReadAllText(f, Encoding.UTF8);
                            global_templates.Add(new FileInfo(f).Name, tplStr);
                        }
                    }
                }
            }
        }
    }
}
