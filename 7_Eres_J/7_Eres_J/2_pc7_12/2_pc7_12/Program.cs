using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando un for y un vector se debe obtener la diagonal principal de una Matriz nxn con datos aleatorios.

            Console.WriteLine("Ingresa el tamaño de la matriz(Recorda que es de igual fila y columna):");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] matriz = new int[n, n];
            int[] vectordiag = new int[n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);

                    Console.WriteLine("matriz1[" + i + "," + j + "]= " + matriz[i, j]);
                    Console.WriteLine(" ");


                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("[" + i + "," + j + "]= " + matriz[i, j]);
                        Console.WriteLine("----------------------------------------------------");
                    }

                }
            }

            Console.ReadKey();

        }
    }
}
