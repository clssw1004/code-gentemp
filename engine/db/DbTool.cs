using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace engine.db
{
    public class DbTool
    {
        public static String tramsCamel(String variable)
        {
            MatchCollection mc = Regex.Matches(variable, "_[0-9a-zA-Z_]{1,1}");
            foreach (Match m in mc)
            {
                variable = variable.Replace(m.Value, m.Value.ToUpper().Replace("_", ""));
            }
            return String.Format("{0}{1}",variable.Substring(0,1).ToLower(),variable.Substring(1));
        }

        public static String getJavaTypeByDbType(String dbType)
        {
            String t = dbType.ToLower();
            switch(t)
            {
                case "varchar":
                case "nvarchat":
                case "text":
                case "longtext":
                case "char":
                    return "String";
                case "int":
                    return "Integer";
                case "date":
                case "datetime":
                    return "Date";
                case "bigint":
                    return "Long";
                case "demical":
                    return "Double";
                default:
                    return "[Unknow Type]";
            }
   
        }
    }
}
