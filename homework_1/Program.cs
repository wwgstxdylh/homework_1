using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class AddNum
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int b = 0;
            int c = 0;
            System.Console.Write("Please input a int:");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            System.Console.Write("Please input a int again:");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            c = a * b;
            System.Console.Write("Their product is " + c);
        }
    }
}