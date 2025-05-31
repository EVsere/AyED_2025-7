using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Durante el evento de ventas "Hot Sale", una tienda en línea desea conocer cuál fue el producto más caro y el más económico que se vendió durante el evento.

El programa solicitará al usuario que ingrese la cantidad de productos vendidos durante el Hot Sale. Luego, pedirá al usuario que ingrese el precio de cada producto, uno por uno. Una vez ingresados todos los precios, el programa determinará cuál fue el precio más alto y cuál fue el precio más bajo. Finalmente, mostrará al usuario los precios más alto y más bajo registrados durante el evento.*/

            //cant de productos
            //precio x producto
            //ordenar de > a <

            //ing cant de productos
            Console.WriteLine("Ingrese la cantidad de productos:");
            int p = int.Parse(Console.ReadLine());

            int[] productos = new int[p];  
            int[] precios = new int[p];   

            for (int i = 0; i < p; i++)
            {
                productos[i] = i + 1;  
                Console.Write("¿Cuál fue el valor del producto n° " + productos[i] + "? ");
                precios[i] = int.Parse(Console.ReadLine());
            }

            //ordenar

            // de < a >
            Array.Sort(precios, productos);
            Console.WriteLine(" ");
            Console.WriteLine("El producto vendido a menor precio fue el producto n°"+ productos[0] + " al precio de "+precios[0]);
            Console.WriteLine("------------------------------------------");
            //dar vuelta ambos
            Array.Reverse(productos);
            Array.Reverse(precios);
            Console.WriteLine("El producto vendido a mayor precio fue el producto n°" + productos[0] + " al precio de " + precios[0]);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lista de precios y productos de mayor precio a menor precio:");
            Console.WriteLine(" ");

            for (int g = 0; g < p; g++)
            {
                Console.WriteLine("Producto n°: " + productos[g]);
                Console.WriteLine("Precio: " + precios[g]);
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
