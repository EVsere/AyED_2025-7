using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa
            //en C# que calcule el resultado de sumar dos 
            // números introducidos por el usuario.
            int num1;
            int numsum;
            int num2;

            Console.WriteLine("Ingrese el num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el num2");
            num2 = int.Parse(Console.ReadLine());

            numsum=num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + numsum);

            Console.ReadKey();

        }
    }
}
