using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract_1_pc7_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vas a crear un menú con opciones para simular una pequeña historia gamer.
           
            
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;
            int op;
            Random rand = new Random();

            
            Console.WriteLine("--- Menú ---");
            Console.WriteLine("1. Mostrar estado del jugador");
            Console.WriteLine("2. Encontrar espada mágica");
            Console.WriteLine("3. Pelear contra un enemigo");
            Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
            Console.WriteLine("5. Salir del juego)");
            Console.WriteLine("Seleccione una opción:");
            op = int.Parse(Console.ReadLine());
            while (op != 1 & op != 2 & op!=3 & op!=4 & op!= 5)
            {
                Console.WriteLine("Esa opcion no existe!");
                Console.WriteLine("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            
            while (op != 5 & salud > 0)
            {
                
                while (op == 1)
                {
                    Console.WriteLine("salud: " + salud);
                    Console.WriteLine("monedas: " + monedas);
                    Console.WriteLine("Enemigos derrotados: " + enemigosDerrotados);
                    Console.WriteLine("Tiene espada?" + tieneEspada);
                    Console.WriteLine("--- Menú ---");
                    Console.WriteLine("1. Mostrar estado del jugador");
                    Console.WriteLine("2. Encontrar espada mágica");
                    Console.WriteLine("3. Pelear contra un enemigo");
                    Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
                    Console.WriteLine("5. Salir del juego)");
                    Console.WriteLine("Seleccione una opción:");
                    op = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                }
                
                switch (op)
                {
                    case 2:
                        if (tieneEspada == true)
                        {
                            Console.WriteLine("Ya tiene una espada!");
                        }
                        else
                        {
                            Console.WriteLine("¡Encontraste la espada mágica!");
                            tieneEspada = true;
                        }
                        
                        break;
                    case 3:
                        if (tieneEspada == true)
                        {
                            Console.WriteLine("Derrotaste un enemigo!");
                            Console.WriteLine("salud-10");
                            salud = salud - 10;
                            Console.WriteLine("Enemigos derrotados +1");
                            enemigosDerrotados = enemigosDerrotados + 1;
                            int probabilidad = rand.Next(1, 101);
                            if (probabilidad <= 30)
                            {
                                Console.WriteLine("¡Conseguiste 10 monedas!");
                                monedas = monedas + 10;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tenes una espada! Fue dificil derrotarlo");
                            Console.WriteLine("salud-30");
                            salud = salud - 30;
                            
                        }
                        
                        break;
                    case 4:
                        if (monedas <= 20)
                        {
                            Console.WriteLine("No tenes suficientes monedas");
                        }
                        else
                        {
                            Console.WriteLine("Compraste la pocion de salud");
                            Console.WriteLine("salud + 20");
                            salud = salud + 20;
                        }
                        
                        break;
                 
                }
                
                
                Console.WriteLine("--- Menú ---");
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada mágica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
                Console.WriteLine("5. Salir del juego)");
                Console.WriteLine("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());
                
                Console.Clear();
                
            }
            if (salud <= 0)
            {
                Console.WriteLine("Perdiste!");
                Console.ReadKey();
            }
            if (op == 5)
            {
                Console.WriteLine("Gracias por jugar!");
                Console.ReadKey();
            }
            

            
            
        }
        
}
}
