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
    public class SimpleTemplate : Template
    {

        public SimpleTemplate(String templateStr) : base(templateStr)
        {
        }
        public SimpleTemplate(String templateFile, Encoding encoding) : base(templateFile, encoding)
        {
        }
        /// <summary>
        /// 解析模版
        /// </summary>
        /// <returns></returns>
        public override String Render(Dictionary<String, Object> args)
        {
            String result = AnalyzeVariable(Content, args);
            result = AnalyzeTemplate(result, args);
            return result;
        }
        /// <summary>
        /// 解析变量
        /// </summary>
        /// <param name="tpl"></param>
        /// <returns></returns>
        protected String AnalyzeVariable(String tpl, Dictionary<String, Object> args)
        {
            String result = Content;
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
        protected String AnalyzeTemplate(String tpl, Dictionary<String, Object> args)
        {
            String result = tpl;
            MatchCollection mc = Regex.Matches(result, Constants.INCLUDE_REGEX);
            foreach (Match m in mc)
            {
                String variable = GetVariable(m.Value, EnumGrammerType.INCLUDE);
                SimpleTemplate template = TemplateFactory.GetTemplate<SimpleTemplate>(variable);
                String value = null;
                if (template != null)
                {
                    value = template.Render(args);
                }
                else
                {
                    value = String.Format(" [can't find template \"{0}\"] ", variable);
                }
                result = result.Replace(m.Value, value);
            }
            return result;
        }



    }
}
