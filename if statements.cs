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
            Console.WriteLine(getmax(6,65,72));
            bool isMale = false;
            bool isTall = false;
            //&& for both conditions to be true, ||or if only one condition is true
            if (isMale || isTall)
            {
                Console.WriteLine("you are male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("you are short male");
            }
            else
            {
                Console.WriteLine("you are not male");
            }
            Console.ReadLine();
        }
        static int getmax(int x, int y, int z)
        {
            int result;
            if (x>y && x>z)
            {
                result = x;
            }else if(y>x && y > z)
            {
                result = y;
            }else 
            {
                result = z;
            }

            return result;
        }
    }
}


