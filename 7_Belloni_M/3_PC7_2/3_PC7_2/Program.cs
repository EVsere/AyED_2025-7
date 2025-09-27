using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC7_2
{
    class Program
    {
        static double Sumar(double a, double b) { return a + b; }
        static double Restar(double a, double b) { return a - b; }
        static double Multiplicar(double a, double b) { return a * b; }
        static double Dividir(double a, double b) { return b == 0 ? 0 : a / b; }

        static void Calculadora(int opcion, double x, double y)
        {
            switch (opcion)
            {
                case 1: Console.WriteLine("Suma: " + Sumar(x, y)); break;
                case 2: Console.WriteLine("Resta: " + Restar(x, y)); break;
                case 3: Console.WriteLine("Multiplicación: " + Multiplicar(x, y)); break;
                case 4: Console.WriteLine("División: " + Dividir(x, y)); break;
                default: Console.WriteLine("Opción inválida"); break;
            }
        }

        static void Main()
        {
            Console.WriteLine("1-Sumar  2-Restar  3-Multiplicar  4-Dividir");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Número 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Calculadora(op, n1, n2);
            Console.ReadKey();
        }
    }
}