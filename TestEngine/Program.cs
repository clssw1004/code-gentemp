using engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = @"${kokd8e}";
            Match m  = Regex.Match(a, Constants.FOR_BEGIN_REGEX);
            Console.WriteLine(Regex.Replace(a,Constants.REPLACE_REGEX,""));
            Console.Read();
        }
    }
}
