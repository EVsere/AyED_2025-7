using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sumar dos matrices de igual tamaño nxn, almacenarlas en una nueva e imprimirla por pantalla.
            Console.WriteLine("Ingresa el tamaño de las matrices(Recorda que son de igual fila y columna):");
            int n = int.Parse(Console.ReadLine());
            
            Random rand = new Random();

            int[,] matriz = new int[n, n];
            int[,] matriz2 = new int[n, n];
            int[,] matrizsum = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                    matriz2[i, j] = rand.Next(1, 101);
                    Console.WriteLine("matriz1[" + i + "," + j + "]= " + matriz[i, j]);
                    Console.WriteLine("matriz2[" + i + "," + j + "]= " + matriz2[i, j]);
                    Console.WriteLine(" ");
                    matrizsum[i, j] = matriz[i, j] + matriz2[i, j];
                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("matrizsum[" + i + "," + j + "]= " + matrizsum[i, j]);
                    Console.WriteLine("----------------------------------------------------");
                }
            }

            Console.ReadKey();
        }
    }
}
