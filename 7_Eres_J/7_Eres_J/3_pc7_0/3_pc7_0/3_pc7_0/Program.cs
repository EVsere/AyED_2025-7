using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc7_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine(decirtext(nombre));
            Console.ReadKey();
        }
        static string decirtext(string nombre)
        {

            return "Hola " + nombre;
        }
    }
}

