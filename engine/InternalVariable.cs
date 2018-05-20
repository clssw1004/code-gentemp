using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
    public class InternalVariable
    {
        private static String[] inter = new String[] { "date", "time", "datetime", "author"};
        public static Boolean IsInternal(String variable)
        {
            return inter.Contains(variable);
        }

        public static String Analyze(String variable)
        {
            switch(variable)
            {
                case "date":
                    return DateTime.Now.ToString("yyyy-MM-dd");
                case "time":
                    return DateTime.Now.ToString("HH:mm:ss");
                case "datetime":
                    return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                default:
                    throw new Exception("unknow internal variable");
            }
        }
    }
}
