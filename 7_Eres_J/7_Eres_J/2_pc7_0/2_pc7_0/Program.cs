using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar la cantidad de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular el promedio de comida que necesitará por invitado. El programa solicitará al usuario que ingrese la cantidad de invitados y luego pedirá la cantidad de comida que cada invitado consume, asegurándose de que los valores ingresados estén dentro del rango permitido (de 1 a 100). Una vez que se hayan ingresado todos los datos, el programa calculará el promedio de comida por invitado y lo mostrará en pantalla.

El programa solicitará al usuario que ingrese la cantidad de invitados a la fiesta.Luego, para cada invitado, el programa solicitará que se ingrese la cantidad de comida que come (un número entre 1 y 100), asegurándose de que el valor ingresado esté dentro del rango permitido. Si el valor ingresado no está dentro del rango, se mostrará un mensaje de error y se pedirá que se ingrese nuevamente.Una vez que se hayan ingresado los datos de todos los invitados, el programa calculará el promedio de comida por invitado. Finalmente, el programa mostrará en pantalla el promedio de comida por invitado.

             */

            // cANTIDAD DE INVITADOS
            //cantidad de comida (Entre 1 y 100(+- no se puede))
            //promedio de comida x inv

            int promcomi= 0;
            int promcomifin=0;
            //Cantidad de invitados
            Console.WriteLine("Ingrese la cantidad de invitados:");
            int cantinvi = int.Parse(Console.ReadLine());

            int[] invi = new int[cantinvi];
            int[] comi = new int[cantinvi];

            //cantidad de comida

            for (int i = 0; i < cantinvi; i++)
            {
                Console.WriteLine("Ingrese la cantidad de Comida del invitado "+(i+1)+":");
                comi[i] = int.Parse(Console.ReadLine());
                while (comi[i] > 100)
                {
                    Console.WriteLine("El limite es 100!");
                    Console.WriteLine("Ingrese la cantidad de Comida del invitado " + i + ":");
                    comi[i] = int.Parse(Console.ReadLine());
                }

                
                
            }

            for (int j = 0; j < cantinvi; j++)
            {
                promcomi += comi[j];
            }
            promcomifin = promcomi / cantinvi;
            
            Console.WriteLine("El promedio de comida por invitado es de: " + promcomifin);
            Console.ReadKey();

        }
    }
}
