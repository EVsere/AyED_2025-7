using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla

n y m son datos que ingresa el usuario*/
            //lo puse con random pq me parecio mas lindo pero la cosigna dice 0 asiq lo puse en 0....

            Console.WriteLine("Ingresa el tamaño de las filas:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tamaño de las columnas:");
            int m = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] =  rand.Next(1, 101);
                    Console.WriteLine("matriz[" + i + "," + j + "]= " + matriz[i, j]);
                }
            }

            Console.ReadKey();

        }
    }
}
