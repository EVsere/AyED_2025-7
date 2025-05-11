using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pida al usuario un número entero positivo
            //y muestre por pantalla la cuenta atrás desde ese número hasta cero.


            int num;

            Console.WriteLine("ingresa un numero entero positivo ");
            num = int.Parse(Console.ReadLine());

            for (int cont = num ; cont <= num; cont--)
            {
                Console.WriteLine(cont);
            }
            Console.ReadKey();
        }
    }
}
