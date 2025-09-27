using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC7_3
{
    class Program
    {
        const int MAX = 25;
        static int cantEncargos = 0;


        static string[] codCamion = new string[MAX];
        static int[] distancia = new int[MAX];
        static int[] sede = new int[MAX];
        static double[] ganancia = new double[MAX];
        static int[] asignado = new int[MAX];

    static void CrearEncargo()
        {
            if (cantEncargos >= MAX)
            {
                Console.WriteLine("No hay más espacio... Estamos a full!");
                return;
            }

            Console.Write("Distancia: ");
        int d = int.Parse(Console.ReadLine());
        if (d <= 0)
            {
                Console.WriteLine("La distancia no puede ser negativa");
            return;
        }

            Console.Write("Sede (1=BSAS,2=BB,3=MDQ): ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Ganancia: ");
            double g = double.Parse(Console.ReadLine());

        distancia[cantEncargos] = d;
            sede[cantEncargos] = s;
            ganancia[cantEncargos] = g;
            codCamion[cantEncargos] = "";
            asignado[cantEncargos] = 0;

            cantEncargos++;
            Console.WriteLine("Encargo registrado");
    }

        static void MostrarTodos()
        {
            for (int i = 0; i < cantEncargos; i++)
            {
                Console.WriteLine($"Encargo {i + 1}: Dist={distancia[i]}, Sede={sede[i]}, G={ganancia[i]}, Camion={codCamion[i]}, Asig={asignado[i]}");
            }
        }

        static void MostrarNoAsignados()
        {
            for (int i = 0; i < cantEncargos; i++)
                if (asignado[i] == 0)
                    Console.WriteLine($"Encargo {i + 1}: Dist={distancia[i]}, G={ganancia[i]}");
        }

        static void AsignarCamion()
        {
            MostrarNoAsignados();
            Console.Write("Elegí número de encargo: ");
            int num = int.Parse(Console.ReadLine()) - 1;


        if (num < 0 || num >= cantEncargos)
            {
                Console.WriteLine("Encargo inválido");
                return;
        }
            if (asignado[num] == 1)
            {
                Console.WriteLine("Ese encargo ya tiene camión");
                return;
            }

            Console.Write("Código de camión: ");
            codCamion[num] = Console.ReadLine();
            asignado[num] = 1;
            Console.WriteLine("Camión asignado");
        }

        static void MostrarAsignados()
        {
            for (int i = 0; i < cantEncargos; i++)
                if (asignado[i] == 1)
                    Console.WriteLine($"Encargo {i + 1}: Camion={codCamion[i]}, Dist={distancia[i]}, G={ganancia[i]}");
        }

        static void PromedioGananciaPorSede()
        {
            double[] total = new double[4];
            int[] cuenta = new int[4];


        for (int i = 0; i < cantEncargos; i++)
            {
                total[sede[i]] += ganancia[i];
                cuenta[sede[i]]++;
        }

            for (int s = 1; s <= 3; s++)
                if (cuenta[s] > 0) 
            Console.WriteLine($"Sede {s}: Prom = {total[s] / cuenta[s]}");
        }

        static void EncargoMayorDistancia()
        {
            int max = -1, pos = -1;
            for (int i = 0; i < cantEncargos; i++) 
            {
                if (distancia[i] > max)
                {
                    max = distancia[i];
                    pos = i;
                }
            }
            if (pos != -1)
                Console.WriteLine($"Mayor distancia: Encargo {pos + 1}, {max} km, G={ganancia[pos]}");
        }

        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Crear encargo");
                Console.WriteLine("2. Mostrar todos");
                Console.WriteLine("3. Asignar camión");
                Console.WriteLine("4. Mostrar asignados");
                Console.WriteLine("5. Promedio por sede");
                Console.WriteLine("6. Mayor distancia");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEncargo(); break;
                    case 2:
                        MostrarTodos(); break;
                    case 3:
                        AsignarCamion(); break;
                    case 4:
                        MostrarAsignados(); break;
                    case 5:
                        PromedioGananciaPorSede(); break;
                    case 6:
                        EncargoMayorDistancia(); break;
                }
            } while (opcion != 0);
        }
    }
}