using System;

class Program
{
    static void marcomost()
    {
        
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine($"{"N°",-3} {"Distancia",-15} {"Sede",-6} {"Monto",-6} {"Camion",-15} {"Asignado"}");
        Console.WriteLine("-----------------------------------------------------------------");
    }

    static void mostrarfun(int[,] encargos, bool[] asignado,  int i)
    {
        
         if (encargos[2, i] == 1)
            {
                Console.WriteLine($"{i,-3} {encargos[1, i],-15} {"BSAS",-6} {encargos[3, i],-6} {encargos[4, i],-15} {asignado[i]}");
            }
            else if (encargos[2, i] == 2)
            {
                Console.WriteLine($"{i,-3} {encargos[1, i],-15} {"BB",-6} {encargos[3, i],-6} {encargos[4, i],-15} {asignado[i]}");
            }
            else if (encargos[2, i] == 3)
            {
                Console.WriteLine($"{i,-3} {encargos[1, i],-15} {"MDQ",-6} {encargos[3, i],-6} {encargos[4, i],-15} {asignado[i]}");
            }
    }


    
    //ya no se que funciones inventarme


    static void nuevoencargo(int[,] encargos, bool[] asignado, int cant, bool ok)
    {
        do
        {
            
            if (encargos[1, cant] <= 0)
            {
                Console.WriteLine("La distancia no puede ser negativa... Es ilegal que los camiones circulen en reversa");
            }

        } while (encargos[1, cant] <= 0);

        do
        {
            Console.WriteLine("Ingrese sede:");

            Console.WriteLine("1. BSAS (Buenos Aires)");
            Console.WriteLine("2. BB (Bahía Blanca)");
            Console.WriteLine("3. MDQ(Mar del Plata)");
            encargos[2, cant] = int.Parse(Console.ReadLine());
            if (encargos[2, cant] == 1 || encargos[2, cant] == 2 || encargos[2, cant] == 3)
            {
                ok = true;
            }

        } while (ok == false);
        
        Console.WriteLine("Ingrese monto:");
        encargos[3, cant] = int.Parse(Console.ReadLine());
        encargos[0, cant] = cant + 1;
    }

    //en mi opinion solo habia que ponerle a lo de mostrar pq es lo unico que se repite pero siento que es poco

    static void filtrarcamion(int[,] encargos, bool[] asignado, int cant, int cd)
    {
        bool repetido;
        
        do
        {
            repetido = false;
            Console.WriteLine("Ingrese matricula del camion a cargo del encargo:");
            int matricula = int.Parse(Console.ReadLine());

            for (int c = 0; c < cant; c++)
            {
                if (encargos[4, c] == matricula)
                {
                    repetido = true;
                    Console.WriteLine("Ese camión ya está asignado a otro encargo. Ingrese otro.");
                    break;
                }
            }

            if (!repetido)
            {
                encargos[4, cd] = matricula;
                asignado[cd] = true;
            }

        } while (repetido);
    }
    static int mayord(int[,] encargos, int cant)
    {
        int mayor = 0;
        for (int i = 0; i < cant; i++)
        {
            if (encargos[1, i] > mayor)
            {
                mayor = encargos[1, i];
            }
        }
        return mayor;
    }

    

    //decidi que en los case solo quede lo necesario para mostrar pq enserio no se que otra funcion hacer
    static void Main(string[] args)
    {
        int[,] encargos = new int[5, 25]; // 0=ID, 1=Distancia, 2=sede, 3 Monto, 4=Camion
        bool[] asignado = new bool[25];
        int cant = 0;
        int desic;
        bool ok = false;
        

        do
        {
            Console.Clear();
            Console.WriteLine("========= MENU =========");
            Console.WriteLine("1. Nuevo encargo");
            Console.WriteLine("2. Mostrar encargos");
            Console.WriteLine("3. Asignar camion");
            Console.WriteLine("4. Mostrar asignados");
            Console.WriteLine("5. Mostrar promedio por sede de ganancia");
            Console.WriteLine("6. Mostrar mayor distancia");
            Console.WriteLine("7. Mostrar encargos por camion");
            Console.WriteLine("8. Salir");
            Console.WriteLine("========================");
            Console.Write("Ingrese una opcion: ");
            desic = int.Parse(Console.ReadLine());

            switch (desic)
            {
                case 1: // Nuevo encargo
                    if (cant >= 25)
                    {
                        Console.WriteLine("No hay más espacio... ¡Estamos a Full!");
                        break;
                    }
                    Console.WriteLine("Ingrese distancia:");
                    encargos[1, cant] = int.Parse(Console.ReadLine());

                    nuevoencargo(encargos, asignado, cant, ok);

                    cant++;
                    break;

                case 2: // Mostrar encargos
                    marcomost();
                    for (int s = 0; s < cant; s++)
                    {
                        mostrarfun(encargos, asignado, s);
                    }
                    Console.ReadKey();
                    break;

                case 3: // Asignar camion
                    Console.WriteLine("Encargos no asignados:");
                    marcomost();
                    for (int i=0;i< cant; i++)
                    {
                        if (asignado[i] == false)
                        {
                            mostrarfun(encargos, asignado, i);
                        }
                    }
                    
                    Console.WriteLine("Ingrese el pedido al que quiere asignarle un camion:");
                    int cd = int.Parse(Console.ReadLine());

                    filtrarcamion(encargos, asignado, cant, cd);
                    break;

                case 4: // Buscar encargo asignado
                    Console.WriteLine("Estos son los encargos que tenemos asignados:");
                    marcomost();
                    for (int n = 0; n < cant; n++)
                    {
                        if (asignado[n] == true)
                        {
                            mostrarfun(encargos, asignado, n);
                        }
                    }
                    
                    Console.ReadKey();
                    break;
                    
                case 5: // Total recaudado x sede
                    int pba = 0;
                    int pbb = 0;
                    int pmdp = 0;
                    int ppba = 0;
                    int ppbb = 0;
                    int ppmdp = 0;
                    for (int i = 0; i < cant; i++)
                    {
                        if (encargos[2, i] == 1)
                        {
                            ppba++;
                            pba += encargos[3, i];
                        }
                        if (encargos[2, i] == 2)
                        {
                            ppbb++;
                            pbb += encargos[3, i];
                        }
                        if (encargos[2, i] == 3)
                        {
                            ppmdp++;
                            pmdp += encargos[3, i];
                        }

                    }
                    Console.WriteLine("Promedio de ganancia por sede:");
                    Console.WriteLine("Buenos Aires: "+pba/ppba);
                    Console.WriteLine("BBahia Blanca: " + pbb / ppbb);
                    Console.WriteLine("Mar del Plata: " + pmdp / ppmdp);
                    Console.ReadKey();
                    break;

                case 6: // encargo conmayor distancia
                    
                    Console.WriteLine("Encargo/s de mayor distancia");
                    marcomost();
                    int mayor = mayord(encargos, cant);
                    for (int i = 0; i < cant; i++)
                    {
                        if (encargos[1, i] == mayor)
                        {
                            mostrarfun(encargos, asignado, i);
                        }
                    }
                    Console.ReadKey();
                    break;

                case 7: // Mostrar encargos por camion
                    Console.WriteLine("Camiones:");
                    for (int j = 0; j < cant; j++)
                    {
                        Console.WriteLine(j + ". " + encargos[4, j]);
                    }
                    Console.WriteLine("Ingrese el código de camión que desea filtrar:");
                    int codigoBuscado = int.Parse(Console.ReadLine());
                    bool encontrado = false;

                    marcomost();
                    for (int j = 0; j < cant; j++)
                    {
                        if (encargos[4, j] == codigoBuscado && asignado[j])
                        {
                            mostrarfun(encargos, asignado, j);
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se encontraron encargos asignados al camión ingresado.");
                    }

                    Console.WriteLine("Presione enter para volver al menu...");
                    Console.ReadKey();
                    break;

                case 8:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }

        } while (desic != 8);
    }
}
