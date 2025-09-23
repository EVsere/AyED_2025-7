
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*La compañía de videojuegos "ZEGA" está desarrollando un nuevo juego de rol (RPG) en el que los jugadores pueden encontrar objetos con diferentes valores. Necesitan un programa que permita identificar en qué posición se encuentran los objetos cuyo valor es mayor a un número dado.

El programa solicitará al usuario que ingrese la cantidad de elementos (objetos) que desea analizar. Luego, pedirá al usuario que ingrese el valor mínimo que deben tener los objetos para ser considerados en el filtro. Seguidamente, el programa solicitará al usuario que ingrese los valores de los objetos, uno por uno. Una vez ingresados todos los valores, el programa mostrará al usuario las posiciones en las que se encuentran los objetos cuyo valor es mayor al número especificado.*/

            Console.Write("Ingrese la cantidad de objetos: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor mínimo para filtrar: ");
            int min = int.Parse(Console.ReadLine());

            int[] objetos = new int[c];
            int[] posic = new int[c];
            Random rand = new Random();

            for (int i = 0; i < c; i++)
            {
                Console.Write("Objeto " + (i + 1) + ": ");
                objetos[i] = int.Parse(Console.ReadLine());
                posic[i] = rand.Next(1, 101);
            }

            for (int l = 0; l < c; l++)
            {
                if (objetos[l] >= min)
                {
                    Console.WriteLine("El objeto nº " + (l + 1) + " se encuentra en la posic: " + posic[l]);
                }
            }

            Console.ReadKey();
        }
    }
}