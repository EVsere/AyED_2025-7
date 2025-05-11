using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_1_pc7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--- Menú ---
            1. Opción 1
            2. Opción 2
            3. Opción 3
            4. Salir
            */
            int op;
            int num1;
            int num2;
            int result;
            int desic;
            string rep;
            int numrep;
            int i;
            Console.WriteLine("--- Menú ---");
            Console.WriteLine("1. suma");
            Console.WriteLine("2. repetir");
            Console.WriteLine("3. resta");
            Console.WriteLine("4. Salir");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Elegiste suma!, necesito 2 numeros");
                    Console.WriteLine("  ");
                    Console.WriteLine("Ingresa el primero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo:");
                    num2 = int.Parse(Console.ReadLine());

                    result = num1 + num2;

                    Console.WriteLine(num1+" + "+num2+"= "+result);

                    break;
                case 2:
                    Console.WriteLine("Elegiste repetir!, necesito saber si queres repetir un numero o  una palabra");
                    Console.WriteLine("  ");
                    Console.WriteLine("1. palabra");
                    Console.WriteLine("2. numero");
                    desic  = int.Parse(Console.ReadLine());
                    while (desic != 1 & desic != 2)
                    {
                        Console.WriteLine("Eso no es una opcion! Elegi otra vez");
                        Console.WriteLine("1. palabra");
                        Console.WriteLine("2. numero");
                        desic = int.Parse(Console.ReadLine());
                    }
                    if (desic == 1)
                    {
                        Console.WriteLine("¿Cual es la palabra que queres repetir?");
                        rep = Console.ReadLine();
                        Console.WriteLine("¿Cuantas veces la queres repetir?");
                        i = int.Parse(Console.ReadLine());
                        for (int cont = 0; cont <= i-1; cont++)
                        {
                            Console.WriteLine(rep);

                        }

                        Console.WriteLine("");
                    }
                    if (desic == 2)
                    {
                        Console.WriteLine("¿Cual es el numero que queres repetir?");
                        numrep = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Cuantas veces lo queres repetir?");
                        i = int.Parse(Console.ReadLine());
                        for (int cont = 0; cont <= i-1; cont++)
                        {
                            Console.WriteLine(numrep);
                        }
                    }
                    

                    break;
                case 3:
                    Console.WriteLine("Elegiste resta!, necesito 2 numeros");
                    Console.WriteLine("  ");
                    Console.WriteLine("Ingresa el primero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo:");
                    num2 = int.Parse(Console.ReadLine());

                    result = num1 - num2;

                    Console.WriteLine(num1 + " - " + num2 + "= " + result);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Chau!");
                    Console.ReadKey();
                break;

             
            }
            Console.ReadKey();
        }
    }
}
