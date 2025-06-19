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
            /*Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para un proyecto importante. Durante el proceso de selección, necesitan un programa que ordene los puntajes obtenidos en un examen de menor a mayor, y luego filtre aquellos puntajes que sean múltiplos de un número dado.

El programa solicitará al usuario que ingrese la cantidad de candidatos que realizaron el examen. Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por uno. Una vez ingresados todos los puntajes, el programa los ordenará de menor a mayor. Posteriormente, el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes múltiplos de ese número. Finalmente, mostrará al usuario la lista de puntajes ordenados y los puntajes que son múltiplos del número especificado.
*/

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