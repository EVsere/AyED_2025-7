using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotar una matriz cuadrada n×n 90 grados en sentido horario.

            Console.WriteLine("Ingresa el tamaño de la matriz(Recorda que es de igual fila y columna):");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int[,] matriz = new int[n, n];
            int[,] matrizord = new int[n, n]; 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                    
                    Console.WriteLine("matriz1[" + i + "," + j + "]= " + matriz[i, j]);
                    Console.WriteLine(" ");
                    matrizord[j, n - 1 - i] = matriz[i, j];


                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine( matrizord[i, j]);

                }
            }

            Console.ReadKey();
        }
    }
}
