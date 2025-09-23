using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre por consola (con un print) los  números de 1 a 100 (ambos incluidos y con un salto de línea entre  cada impresión), sustituyendo los siguientes: 
 - Múltiplos de 3 por la palabra "fizz". 
 - Múltiplos de 5 por la palabra "buzz". 
 - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
*/
            Console.WriteLine("0");
            for (int i = 1; i <= 100; i++)
            {
                
                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    Console.Write(" FizzBuzz ");
                }
                else if ((i % 5) == 0)
                {
                    Console.Write(" Buzz ");
                }
                else if ((i % 3) == 0)
                {
                    Console.Write(" Fizz ");
                }
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
