using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea de su juego más popular, "Galaxy Quest". Para determinar los ganadores, necesitan un programa que ordene los puntajes de los jugadores de mayor a menor.
El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo.Luego, pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.Una vez ingresados todos los puntajes, el programa los ordenará de mayor a menor.Finalmente, mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) y el último lugar (menor puntaje).*/

            Console.WriteLine("Ingrese la cantidad de participantes:");
            int p = int.Parse(Console.ReadLine());

            int[] jugadores = new int[p];  // Jugador 1, 2, 3, ...
            int[] puntajes = new int[p];   // Puntaje correspondiente

            for (int i = 0; i < p; i++)
            {
                jugadores[i] = i + 1;  // Jugador número i+1
                Console.Write("¿Cuál fue el puntaje del jugador " + jugadores[i] + "? ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }
            //ordenar
            // de < a >
            Array.Sort(puntajes, jugadores);
            //dar vuelta ambos
            Array.Reverse(puntajes);
            Array.Reverse(jugadores);

            for (int g = 0; g < p; g++)
            {
                Console.WriteLine("jugador n°: " + jugadores[g]);
                Console.WriteLine("Puntaje: " + puntajes[g]);
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
