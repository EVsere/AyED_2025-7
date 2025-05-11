using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_tp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pregunte
            //al usuario su edad y muestre por pantalla todos los años
            //que ha cumplido (desde 1 hasta su edad).

            int edad; 

            Console.WriteLine("cuantos años tenes?");
            edad = int.Parse(Console.ReadLine());

            for (int cont = 0; cont <= edad; cont++)
            {
                Console.WriteLine(cont);
            }
            Console.ReadKey();
        }
    }
}
