using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pida al usuario una palabra 
            //y la muestre por pantalla 10 veces.

            string pal;
            Console.WriteLine("Ingrese una palabra");
            pal = (Console.ReadLine());
            for (int cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine(pal);

            }
            Console.ReadKey();
        }
    }
}
