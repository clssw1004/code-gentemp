using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace engine
{
    public class ForeachTemplate : Template
    {
        public ForeachTemplate(String templateStr) : base(templateStr)
        {
        }
        public ForeachTemplate(String templateFile, Encoding encoding) : base(templateFile, encoding)
        {
        }
        public override String Render(Dictionary<String, Object> args)
        {
            SimpleTemplate st = new SimpleTemplate(Content);
            String result = st.Render(args);
            MatchCollection mc = Regex.Matches(result, Constants.FOR_BEGIN_REGEX);
            return result;
        }
    }
}
