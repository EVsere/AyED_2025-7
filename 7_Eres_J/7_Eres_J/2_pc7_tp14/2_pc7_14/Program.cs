using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //un tp mas largo no tenias no?...
            //ash... primero el menu....



            string[,] pochimons = new string[75, 7];
            bool[] investigado = new bool[75];
            int cant = 0;
            int b = 0;
            string nombre = "—";
            string tipo = "—";
            int nivel = 0;
            string investigador = "—";
            string estaInvestigado = "—";
            int desic = 0;

           
                do
                {
                    Console.Clear();
                    Console.WriteLine("---------Menu---------");
                    Console.WriteLine("1. Registrar Pochimon");
                    Console.WriteLine("2.Asignar Investigador a Pochimon");
                    Console.WriteLine("3.Actualizar Nivel de Pochimon");
                    Console.WriteLine("4.Marcar Pochimon como Investigado");
                    Console.WriteLine("5.Mostrar Información de Pochimons");
                    Console.WriteLine("6.Buscar Pochimons por Tipo");
                    Console.WriteLine("7.Mostrar Pochimons por Investigador");
                    Console.WriteLine("8.Mostrar Pochimons Picados");
                    Console.WriteLine("9.Salir");
                    Console.WriteLine("-------------------------------------------");
                    desic = int.Parse(Console.ReadLine());
                    switch (desic)
                    {
                        case 1:

                        if (cant < 75)
                        {
                            Console.WriteLine("Ingrese el nombre del Pochimon:");
                            pochimons[cant, 1] = Console.ReadLine();
                            Console.WriteLine("Ingrese el tipo del Pochimon (A / F / P):");
                            pochimons[cant, 2] = Console.ReadLine();
                            Console.WriteLine("Ingrese el nivel del Pochimon:");
                            pochimons[cant, 3] = Console.ReadLine();
                            Console.WriteLine("Presione enter para volver al menu...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Completaste la pochidex!! Felicidades, toma tu recompensa: 🎖");
                            Console.WriteLine("Es una medalla por ser el mejor pochitrainer!");
                        }
                        cant++;
                        break;
                        case 2:
                            Console.WriteLine("Ingrese el numero de Pochimon que busca:");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el investigador que desea asignarle:");
                            pochimons[b, 5] = Console.ReadLine();
                            Console.WriteLine("Presione enter para volver al menu...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el numero de Pochimon que busca:");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nivel que desea asignarle:");
                            pochimons[b, 3] = Console.ReadLine();
                            Console.WriteLine("Presione enter para volver al menu...");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el Pochimon que quiere marcar como investigado:");
                            b = int.Parse(Console.ReadLine());
                            investigado[b] = true;
                            Console.WriteLine("¡Pochimon marcado como investigado!");
                            Console.WriteLine("Presione enter para volver al menú...");
                            Console.ReadKey();

                            break;
                        // ... (el resto del código queda igual hasta los case)

                        case 5:
                            Console.WriteLine("Listado de Pochimons:");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine($"{"N°",-3} {"Nombre",-15} {"Tipo",-6} {"Nivel",-6} {"Investigador",-15} {"Investigado"}");
                            Console.WriteLine("-----------------------------------------------------------------");

                            for (int j = 0; j < cant; j++)
                            {
                                nombre = pochimons[j, 1] ?? "—";
                                tipo = pochimons[j, 2] ?? "—";

                                string nivelStr = pochimons[j, 3];
                                if (nivelStr == null || nivelStr == "—" || nivelStr == "")
                                {
                                    nivelStr = "0";
                                }
                                nivel = int.Parse(nivelStr);

                                investigador = pochimons[j, 5] ?? "—";
                                estaInvestigado = investigado[j] ? "Sí" : "No";

                                Console.WriteLine($"{j,-3} {nombre,-15} {tipo,-6} {nivel,-6} {investigador,-15} {estaInvestigado}");
                            }

                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Presione una tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.WriteLine("Ingrese el tipo de Pochimon que quiere buscar:");
                            string t = Console.ReadLine();
                            Console.WriteLine("Listado de Pochimons ordenados por tipo:");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine($"{"N°",-3} {"Nombre",-15} {"Tipo",-6} {"Nivel",-6} {"Investigador",-15} {"Investigado"}");
                            Console.WriteLine("-----------------------------------------------------------------");

                            for (int k = 0; k < cant; k++)
                            {
                                nombre = pochimons[k, 1] ?? "—";
                                tipo = pochimons[k, 2] ?? "—";

                                string nivelStr = pochimons[k, 3];
                                if (nivelStr == null || nivelStr == "—" || nivelStr == "")
                                {
                                    nivelStr = "0";
                                }
                                nivel = int.Parse(nivelStr);

                                investigador = pochimons[k, 5] ?? "—";
                                estaInvestigado = investigado[k] ? "Sí" : "No";

                                if (t == tipo)
                                {
                                    Console.WriteLine($"{k,-3} {nombre,-15} {tipo,-6} {nivel,-6} {investigador,-15} {estaInvestigado}");
                                }
                            }

                            Console.WriteLine("Presione enter para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.WriteLine("Ingrese el investigador de Pochimon que quiere buscar:");
                            string ent = Console.ReadLine();
                            Console.WriteLine("Listado de Pochimons ordenados por investigador:");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine($"{"N°",-3} {"Nombre",-15} {"Tipo",-6} {"Nivel",-6} {"Investigador",-15} {"Investigado"}");
                            Console.WriteLine("-----------------------------------------------------------------");

                            for (int k = 0; k < cant; k++)
                            {
                                nombre = pochimons[k, 1] ?? "—";
                                tipo = pochimons[k, 2] ?? "—";

                                string nivelStr = pochimons[k, 3];
                                if (nivelStr == null || nivelStr == "—" || nivelStr == "")
                                {
                                    nivelStr = "0";
                                }
                                nivel = int.Parse(nivelStr);

                                investigador = pochimons[k, 5] ?? "—";
                                estaInvestigado = investigado[k] ? "Sí" : "No";

                                if (ent == investigador)
                                {
                                    Console.WriteLine($"{k,-3} {nombre,-15} {tipo,-6} {nivel,-6} {investigador,-15} {estaInvestigado}");
                                }
                            }

                            Console.WriteLine("Presione enter para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.WriteLine("Listado de Pochimons picados:");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine($"{"N°",-3} {"Nombre",-15} {"Tipo",-6} {"Nivel",-6} {"Investigador",-15} {"Investigado"}");
                            Console.WriteLine("-----------------------------------------------------------------");

                            for (int k = 0; k < cant; k++)
                            {
                                nombre = pochimons[k, 1] ?? "—";
                                tipo = pochimons[k, 2] ?? "—";

                                string nivelStr = pochimons[k, 3];
                                if (nivelStr == null || nivelStr == "—" || nivelStr == "")
                                {
                                    nivelStr = "0";
                                }
                                nivel = int.Parse(nivelStr);

                                investigador = pochimons[k, 5] ?? "—";
                                estaInvestigado = investigado[k] ? "Sí" : "No";

                                if (nivel >= 30)
                                {
                                    Console.WriteLine($"{k,-3} {nombre,-15} {tipo,-6} {nivel,-6} {investigador,-15} {estaInvestigado}");
                                }
                            }

                            Console.WriteLine("Presione enter para volver al menú...");
                            Console.ReadKey();
                            break;
                        case 9:
                            Console.WriteLine("Gracias por usar la Pochidex!");
                            break;
                        default:
                            Console.WriteLine("Esa opción no existe. Intentá de nuevo.");
                            break;
                    }




                } while (desic != 9);
                
            
        }
        }
    }
