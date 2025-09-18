using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc7_5
{
    class Program
    {
        static void Main()
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;
            Console.WriteLine("=== Hollow Knight: Simulador básico ===");
            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.Write("\nAcción (atacar/curar/salir): ");
                string accion = Console.ReadLine();
                if (accion == "atacar")
                {
                    hpEnemigo = Atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = Curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción no válida.");

                    //Hollow Knight 2
                
}
                // Enemigo ataca automáticamente
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
                }
            }
            Console.WriteLine("\n=== Resultado ===");
            if (hpHornet <= 0) Console.WriteLine("Hornet ha caído...");
            else if (hpEnemigo <= 0) Console.WriteLine("¡Hornet ganó!");
            else Console.WriteLine("Batalla interrumpida.");
        }
        // -------------------
        // ACA DEBEN CREAR LAS FUNCIONES:
        // 1) Atacar
        // 2) Curar
        // 3) MostrarEstado
        // -------------------


        static void MostrarEstado(int hpHornet, int hpEnemigo)
        {
            Console.WriteLine("HP Hornet: "+hpHornet + "  || HP Enemigo: " + hpEnemigo);
        }

        static int Atacar(int atkHornet, int hpEnemigo)
        {
            hpEnemigo-=atkHornet;
            return hpEnemigo;
        }

        static int Curar(int hpHornet, int hpMaxHornet)
        {
            if (hpHornet < hpMaxHornet)
            {
                hpHornet += 5;
            }
            if (hpHornet >= hpMaxHornet)
            {
                Console.WriteLine("el maximo de HP es 10!");
                hpHornet = hpMaxHornet;
            }
            return hpHornet;
        }
}
}
