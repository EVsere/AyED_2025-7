using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa en C# que le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas importantes. 

El programa debe cumplir el siguiente orden:
Permitir al Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos. Utiliza un array para almacenar estos tiempos.
Calcular y mostrar en pantalla el tiempo total de la carrera.
Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor tiempo registrado.
El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.

(Opcional: los tiempos se pueden ingresar automáticamente con un for y un Random... recordar nombreRandom.Next(10, 500) ).
*/

            Console.WriteLine("Ingrese la cantidad de vueltas de la carrera:");
            int v = int.Parse(Console.ReadLine());
            int[] vueltas = new int[v];
            int tiempotot=0;
            int promvuel = 0;
            double promvuelfin = 0;
            

            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("¿Cual fue el tiempo de la vuelta "+(i+1)+"?");
                int tiempo = int.Parse(Console.ReadLine());
                vueltas[i] = tiempo;
                tiempotot += vueltas[i];
            }

            Console.WriteLine("Tiempo total de vueltas: " + tiempotot);

            
            for (int j = 0; j < v; j++)
            {
                promvuel += vueltas[j];
            }
            promvuelfin = promvuel / v;
            Console.WriteLine("Tiempo promedio por vueltas: " + promvuelfin);

            int mejorTiempo = vueltas[0];
            int mejorVuelta = 1;

            for (int k = 1; k < v; k++)
            {
                if (vueltas[k] < mejorTiempo)
                {
                    mejorTiempo = vueltas[k];
                    mejorVuelta = k + 1;
                }
            }

            Console.WriteLine("La mejor vuelta fue la vuelta " + mejorVuelta + " con un tiempo de " + mejorTiempo + " minuto.");


            Console.ReadKey();
        }
    }
}
