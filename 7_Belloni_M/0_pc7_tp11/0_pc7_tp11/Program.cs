using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // altura (y) de un rectángulo y calcule el perímetro, el área y la diagonal.
            double per;
            double area;
            double diag;
            double x;
            double y;

            Console.WriteLine("Ingrese el ancho");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el largo");
            y = int.Parse(Console.ReadLine());

            per = 2 * x + 2 * y;
            area = y * x;
            diag =  Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));

            Console.WriteLine("perimetro = " + per);
            Console.WriteLine("diagonal = " + diag);
            Console.WriteLine("area = " + area);

            Console.ReadKey();

        }
    }
}
