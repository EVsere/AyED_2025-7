using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc7_tp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua. En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados. La escala de Kelvin es una escala absoluta utilizada en ciencias.
            //Cree un programa en C# para convertir grados centígrados a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados centígrados para convertirlos

            double kel;
            double far;
            double gc;
          

          

            Console.WriteLine("Ingrese la cantidad de grados centigrados");
            gc = int.Parse(Console.ReadLine());

            //pasaje de celcius a kelvin

            kel = gc + 273.15;

            //pasaje de kelvin a far

            far = (kel - 273.15) * (9 / 5) + 32;

            Console.WriteLine("Fahrenheit: " + far);
            Console.WriteLine("Kelvin: " + kel);

            Console.ReadKey();

        }
    }
}
