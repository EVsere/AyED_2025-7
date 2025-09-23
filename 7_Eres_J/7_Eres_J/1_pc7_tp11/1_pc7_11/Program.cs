using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Recorre los números del 1 al N. (N lo tiene que ingresar el usuario).
Muestra solamente los números pares.*/

            int num;

            Console.WriteLine(" Ingresa un numero entero");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
