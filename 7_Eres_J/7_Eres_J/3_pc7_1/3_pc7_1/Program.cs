using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc7_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("decime un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("decime otro numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+"+"+num2+"="+suma(num1, num2));
            Console.ReadKey();
        }
        static int suma(int num1,int num2)
        {

            return num1+num2;
        }
    }
}

