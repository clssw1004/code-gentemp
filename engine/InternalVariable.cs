using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
    public class InternalVariable
    {
        private static String[] inter = new String[] { "_date", "_time", "_datetime", "_hostname", "_OS" , "_appInfo" };
        public static Boolean IsInternal(String variable)
        {
            return inter.Contains(variable);
        }
        public static String Analyze(String variable)
        {
            switch (variable)
            {
                case "_date":
                    return DateTime.Now.ToString("yyyy-MM-dd");
                case "_time":
                    return DateTime.Now.ToString("HH:mm:ss");
                case "_datetime":
                    return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                case "_hostname":
                    return System.Net.Dns.GetHostName();
                case "_OS":
                    return Environment.OSVersion.VersionString;
                case "_appInfo":
                    return "Generate by code-gentemp V0.1";
                default:
                    throw new Exception("unknow internal variable");
            }
        }
    }
}
