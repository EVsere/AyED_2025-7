using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_1_pc7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que pregunte una y otra vez si desea terminar el programa, salvo si se contesta exactamente SI (en mayúsculas y sin tilde).
            string resp;

            Console.WriteLine("Desea cerrar el programa?");
            resp = Console.ReadLine();

            while (resp != "SI")
            {
                Console.WriteLine("Desea cerrar el programa?");
                resp = Console.ReadLine();
            }
            


            Console.ReadKey();
        }
    }
}
