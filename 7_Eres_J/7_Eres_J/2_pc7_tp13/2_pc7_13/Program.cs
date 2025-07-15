using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz Nx3 donde cada fila representa un estudiante y cada columna contiene información como el nombre, la edad y la calificación.

            Random rand = new Random();
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int n = int.Parse(Console.ReadLine());

            string[,] matriz = new string[n, 3];




            for (int i = 0; i < n; i++)
            {

                Console.Write("Nombre: ");
                matriz[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                matriz[i, 1] = Console.ReadLine();

                Console.Write("Nota: ");
                matriz[i, 2] = Console.ReadLine();

            }

            Console.WriteLine("Nombre    Edad   Nota");
            Console.WriteLine("------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, 0] + "    " + matriz[i, 1] + "     " + matriz[i, 2]);
            }

            Console.ReadKey();
        }
    }
}
