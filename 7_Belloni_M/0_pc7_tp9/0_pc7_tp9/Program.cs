using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
            //(El radio lo deberá ingresar el usuario).
            double vol;
            double r;
            double sup;
            double pi;

            pi = 3.14;

            Console.WriteLine("Ingrese el radio");
            r = int.Parse(Console.ReadLine());
         
            sup = 4 * pi*r*r;
            vol = 4/3 * pi*r*r*r;

            Console.WriteLine("volumen: " + vol);
            Console.WriteLine("superficie: " + sup);

            Console.ReadKey();

           

        }
    }
}
