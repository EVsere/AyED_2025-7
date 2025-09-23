using System;

namespace _2_pc7_tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del vector:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random rand = new Random();
            int desic = 0;
            for (int i = 0; i < n; i++)
            {
                vector[i] = rand.Next(1, 101);
            }

            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("¿Qué desea hacer con el vector?");
                Console.WriteLine("1. Mostrar");
                Console.WriteLine("2. Buscar un número dentro de él");
                Console.WriteLine("3. Ordenar");
                Console.WriteLine("4. Cerrar el programa");
                Console.WriteLine("----------------------------");
                desic = int.Parse(Console.ReadLine());

                switch (desic)
                {
                    case 1:

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Vector[" + i + "] = " + vector[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Que número querés buscar?");
                        int b = int.Parse(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < n; i++)
                        {
                            if (vector[i] == b)
                            {
                                Console.WriteLine("¡Lo encontré! Está en la posición: " + i);
                                encontrado = true;
                                break;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No existe dentro del vector, perdón :(");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Como lo queres ordenar?");
                        Console.WriteLine("1. de < a >");
                        Console.WriteLine("2. de > a <");
                        int desic2 = int.Parse(Console.ReadLine());

                        switch (desic2)
                        {
                            case 1:
                                Array.Sort(vector);
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("Vector[" + (i) + "]= " + vector[i]);

                                }
                                break;
                            case 2:
                                Array.Sort(vector);
                                Array.Reverse(vector);
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("Vector[" + (i) + "]= " + vector[i]);

                                }
                                break;
                            default:
                                Console.WriteLine("Esa opcion no existe! Volve a ingresar:");
                                desic2 = int.Parse(Console.ReadLine());
                                break;
                        }

                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Esa opción no existe. Intentá de nuevo.");
                        break;
                }



            } while (desic != 4);
        }
    }
}