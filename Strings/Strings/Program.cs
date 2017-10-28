using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Strings
{
    class Program
    {
        static string Copies(string s, string s1, int n)
        {
            var result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(s);
            }
            return s1 + result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of iterations: ");
            var n = int.Parse(Console.ReadLine());
            var s = File.ReadAllText(@".\strings.txt");
            var s1 = File.ReadAllText(@".\tmp.txt");
            s1 =  Copies(s, s1, n);
            Console.WriteLine("Result: "+s1);
            File.WriteAllText(@"d:\strings2.txt",s1);
            Console.ReadKey();
        }
    }
}
