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
        private String[] TemplateStr;
        public Dictionary<String, String> Args { get; set; }
        public Template(String templateFile)
        {
            if (File.Exists(templateFile))
            {
                TemplateStr = File.ReadAllLines(templateFile);
            }
            Args = new Dictionary<string, string>();
        }
        public Template(String templateFile, Dictionary<String, String> args)
        {
            if (File.Exists(templateFile))
            {
                TemplateStr = File.ReadAllLines(templateFile);
            }
            Args = args;
        }
        /// <summary>
        /// 解析模版
        /// </summary>
        /// <returns></returns>
        public String Analyze()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in TemplateStr)
            {
                sb.AppendLine(dealLine(line));
            }
            return sb.ToString();
        }
        /// <summary>
        /// 解析行
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private String dealLine(String line)
        {
            String result = line;
            if (Regex.IsMatch(line, Constants.ARG_REGEX))
            {
                MatchCollection mc = Regex.Matches(line, Constants.ARG_REGEX);
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
                        value = GetValue(variable);
                    }
                    result = result.Replace(m.Value, value);
                }
            }
            else if (Regex.IsMatch(line, Constants.INCLUDE_REGEX))
            {
                Match m = Regex.Match(line, Constants.INCLUDE_REGEX);
                String variable = GetVariable(m.Value, EnumGrammerType.INCLUDE);
                Template template = GetTemplate(variable);
                if (template != null)
                {
                    result = template.Analyze();
                }
                else
                {
                    result = String.Format(" [can't find template \"{0}\"] ", variable);
                }
            }
            return result;
        }
        private String GetValue(String variable)
        {
            if (Args.ContainsKey(variable))
            {
                return Args[variable];
            }
            return String.Format(" [\"{0}\" is undefined] ", variable);
        }
        private static Template GetTemplate(String tpName)
        {
            return new Template(tpName);
        }
        private static String GetVariable(String m, EnumGrammerType type)
        {
            String variable = m;
            switch (type)
            {
                case EnumGrammerType.ARG:
                    variable = replaceToBlank(variable,"${", "}");
                    break;
                case EnumGrammerType.INCLUDE:
                    variable = replaceToBlank(variable,"$include{", "}");
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
    }
}
