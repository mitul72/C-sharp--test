using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*data types string, int, char,bool, 
            (float-suffix-F, double-suffix-D, decimal-suffix-D for decimal values)*/
            string a;
            int b = 5;
            char c = 'h';
            char space= ' ';
            char[] d = {'h', 'g'};
            decimal e = 0.000000005M;
            bool isMale;
            isMale = false;
            a = "bye";
            Console.WriteLine("ab\"c "+a+space+ d[1]);
            a = "hi";
            Console.WriteLine(4.55+" "+a.Length);
            Console.WriteLine(e);
            Console.WriteLine("abcde fgh".Substring(6));
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(5.0 / 2);
            
            Console.WriteLine("hello " + name);
            Console.ReadLine();           
        }
    }
}
