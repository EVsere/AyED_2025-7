using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //El usuario debe ingresar si tiene comida (sí o no), 
            //un refugio (sí o no) y un bate (sí o no). 
            //El programa debe decir si sobrevive o no.
            //Si tiene comida, refugio y un bate → sobrevive
            //Si le falta algo → no sobrevive

            string comida;
            string refugio;
            string bate;

            Console.WriteLine("Tenes comida?");
            comida = (Console.ReadLine());
            Console.WriteLine("tenes un refugio?");
            refugio = (Console.ReadLine());
            Console.WriteLine("tenes un bate?");
            bate = (Console.ReadLine());

            if (comida == "si" && refugio == "si" && bate == "si")
            {
                Console.WriteLine("genial, sobreviviste!");
            }
            else if (comida == "no" && refugio == "no" && bate == "no")
            {
                Console.WriteLine("no sobreviviste");
            }
           
        


            Console.ReadKey();


        }
    }
}
