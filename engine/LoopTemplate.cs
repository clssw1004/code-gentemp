using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace engine
{
    /// <summary>
    /// 解析for语法
    /// </summary>
    public class LoopTemplate : Template
    {
        public LoopTemplate(String templateStr) : base(templateStr)
        {
        }
        public LoopTemplate(String templateFile, Encoding encoding) : base(templateFile, encoding)
        {
        }
        public override String Render(Dictionary<String, Object> args)
        {
            StringBuilder sb = new StringBuilder();

            Match m = Regex.Match(Content, Constants.FOR_BEGIN_REGEX);
            if (m.Success)
            {
                String variable = GetVariable(m.Value);
                if (args.ContainsKey(variable) && args[variable] is List<Dictionary<String, Object>>)
                {
                    List<Dictionary<String, Object>> loopArgs = args[variable] as List<Dictionary<String, Object>>;
                    int firstIndex = Content.IndexOf(m.Value);
                    String endFor = String.Format(@"$endfor{0}{1}{2}", "{",variable,"}");
                    int lastIndex = Content.LastIndexOf(endFor);
                    if (firstIndex >= 0 && lastIndex >= 0)
                    {
                        if (firstIndex >= 0)
                        {
                            SimpleTemplate prevFor = new SimpleTemplate(Content.Substring(0, firstIndex));
                            sb.Append(prevFor.Render(args));
                        }
                        String loopBody = RemoveForTag(Content.Substring(firstIndex, lastIndex - firstIndex), variable);
                        foreach (var argItem in loopArgs)
                        {
                            if(Regex.IsMatch(loopBody,Constants.FOR_BEGIN_REGEX))
                            {
                                LoopTemplate lt = new LoopTemplate(loopBody);
                                sb.Append(lt.Render(argItem));
                            }
                            else
                            {
                                SimpleTemplate st = new SimpleTemplate(loopBody);
                                sb.Append(st.Render(argItem));
                            }
                                
                        }
                        if (lastIndex >= 0)
                        {
                            SimpleTemplate afterFor = new SimpleTemplate(Content.Substring(lastIndex));
                            sb.Append(afterFor.Render(args));
                        }
                    }


                }
            }
            return sb.ToString();
        }
        private static String RemoveForTag(String loopTempolateStr, String variable)
        {
            String replaceStr = String.Format(@"\$for\{0}{1}\{2}|\$endfor\{0}{1}\{2}", "{",variable,"}");
            return Regex.Replace(loopTempolateStr, replaceStr, "");
        }
    }
}
