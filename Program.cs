using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;//Value Type
            Console.WriteLine(num);
            object obj; //Reference Type
            obj = num;//Boxing 
            Console.WriteLine(obj);

            int num2;
            num2 = (int)obj; //UnBoxing
            Console.WriteLine(num2);
            Console.ReadKey();


        }
    }
}
