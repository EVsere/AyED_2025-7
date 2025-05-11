using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Escribe un programa en C# que calcule el resultado de dividr dos números introducidos por el usuario.
            int num1;
            int numdiv;
            int num2;

            Console.WriteLine("Ingrese el num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el num2");
            num2 = int.Parse(Console.ReadLine());

            numdiv = num1 / num2;

            Console.WriteLine(num1 + " / " + num2 + " = " + numdiv);

            Console.ReadKey();

        }
    }
}
