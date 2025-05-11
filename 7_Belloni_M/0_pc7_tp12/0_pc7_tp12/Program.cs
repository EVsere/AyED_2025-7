using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.
           
            Console.Write("Letra 1: ");
            char letra1 = Console.ReadKey().KeyChar;
            Console.WriteLine("                  ");

            
            Console.Write("Letra 2: ");
            char letra2 = Console.ReadKey().KeyChar;
            Console.WriteLine("                  ");

           
            Console.Write("Letra 3: ");
            char letra3 = Console.ReadKey().KeyChar;
            Console.WriteLine("                  ");

            
            Console.WriteLine("Letras en orden inverso:", letra3, letra2, letra1);


            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();


            
            
        }
    }
}
