using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Escribe un programa en C# que calcule el RESTO de la división entre dos números introducidos por el usuario.
            int num1;
            int numrest;
            int num2;

            Console.WriteLine("Ingrese el num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el num2");
            num2 = int.Parse(Console.ReadLine());

            numrest = num1 % num2;

            Console.WriteLine(num1 + " % " + num2 + " = " + numrest);

            Console.ReadKey();


        }
    }
}
