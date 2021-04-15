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
            Console.Write("enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum is: "+ (a +b));

            Console.ReadLine();
        }
    }
}
