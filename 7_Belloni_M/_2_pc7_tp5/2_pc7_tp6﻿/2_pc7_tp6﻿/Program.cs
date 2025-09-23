using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de participantes:");
            int p = int.Parse(Console.ReadLine());

            int[] aplicantes = new int[p];
            int[] notas = new int[p];
            int min;
            Console.Write("¿Cuál es el numero para filtrar por multiplos? ");
            min = int.Parse(Console.ReadLine());

            for (int i = 0; i < p; i++)
            {
                aplicantes[i] = i + 1;
                Console.Write("¿Cuál fue la nota del aplicante " + aplicantes[i] + "? ");
                notas[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(notas, aplicantes);

            for (int g = 0; g < p; g++)
            {
                Console.WriteLine("Aplicante n°: " + aplicantes[g]);
                Console.WriteLine("Nota: " + notas[g]);

                Console.WriteLine("Cumple con el filtro?");

                if (notas[g] % min == 0)
                {
                    Console.WriteLine("Si");
                }
                else
                {
                    Console.WriteLine("No");
                }
                Console.WriteLine("------------------------------------------");

            }


            Console.ReadKey();

        }
    }
}
