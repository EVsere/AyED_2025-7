using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir al usuario que ingrese la temperatura en grados Celsius.
            //Según el valor, informar:
            //Si es menor o igual a 0 → "Se congela"
            //Si es mayor o igual a 100 → "Hierve"
            //Si está entre 1 y 99 → "Está en estado líquido"

            double gc;


            Console.WriteLine("Ingrese la tempertura de grados celsius");
            gc = int.Parse(Console.ReadLine());
             
            if ( gc <= 0)
            {
                Console.WriteLine("se congela!");
            }
            else if(gc >= 100)
            {
                Console.WriteLine("hierve");
            }
            else if ( gc >= 1 && gc <= 99)
            {
                Console.WriteLine("esta en estado liquido");
            }
            Console.ReadKey();
        }

    }
}