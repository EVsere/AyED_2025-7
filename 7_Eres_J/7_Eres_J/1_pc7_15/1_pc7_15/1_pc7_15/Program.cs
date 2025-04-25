using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc7_15
{
class Program
{
static void Main(string[] args)
{
/*Simulá un juego donde el personaje está atrapado en una isla y debe sobrevivir
durante 7 días.Cada día puede realizar distintas acciones, pero algunas tienen
una probabilidad de tener consecuencias malas o buenas. Para esto, vas a
utilizar números aleatorios (Random).
*/
Random rand = new Random();
int salud = 100;
int hambre = 50;
int energia = 70;
int dia = 1;
int desic;
bool sigueVivo = true;



Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
desic = int.Parse(Console.ReadLine());


if (dia == 1)
{
            int probabilidad = rand.Next(1, 101);
            switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
            
}
if (sigueVivo == false)
{
Console.ReadKey();
}


}


if (dia == 2)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
int probabilidad = rand.Next(1, 101);
desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
}
if (sigueVivo == false)
{
Console.ReadKey();
}


}


if (dia == 3)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
        int probabilidad = rand.Next(1, 101);
        desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
}
if (sigueVivo == false)
{
Console.ReadKey();
}

}


if (dia == 4)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
        int probabilidad = rand.Next(1, 101);
        desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
}
if (sigueVivo == false)
{
Console.ReadKey();
}
}




if (dia == 5)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
            int probabilidad = rand.Next(1, 101);
            desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
}
if (sigueVivo == false)
{
Console.ReadKey();
}
}


if (dia == 6)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
            int probabilidad = rand.Next(1, 101);
            desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
Console.WriteLine("¡Comiste algo en mal estado! salud-15");
salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
            else
            {
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }

            break;
        case 4:
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            while (desic == 4)
            {
                Console.WriteLine("¿Qué querés hacer?");
                Console.WriteLine(" 1. Buscar comida ");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla ");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego ");
                Console.WriteLine("¿Que desea hacer ahora?");
                desic = int.Parse(Console.ReadLine());
                switch (desic)
                {
                    case 1:
                        hambre = hambre + 20;
                        energia = energia - 15;

                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                            salud = salud - 15;
                        }
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 2:
                        energia = energia + 30;
                        hambre = hambre - 10;
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                        break;
                    case 3:

                        if (probabilidad >= 50)
                        {
                            Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                            salud = salud + 10;
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }
                        else
                        {
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Hambre: " + hambre);
                        }

                        break;
                    case 5:
                        Console.WriteLine("¡Adios, Gracias por jugar!");
                        Console.ReadKey();
                        break;
                }

            }
            break;
        case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
dia = dia + 1;
}
if (sigueVivo == false)
{
Console.ReadKey();
}
}


if (dia == 7)
{
Console.WriteLine("Día" + dia + " – ¿Qué querés hacer?");
Console.WriteLine(" 1. Buscar comida ");
Console.WriteLine("2. Dormir");
Console.WriteLine("3. Explorar la isla ");
Console.WriteLine("4. Ver estado del personaje");
Console.WriteLine("5. Salir del juego ");
int probabilidad = rand.Next(1, 101);
desic = int.Parse(Console.ReadLine());
switch (desic)
{
case 1:
hambre = hambre + 20;
energia = energia - 15;

if (probabilidad <= 30)
{
    Console.WriteLine("¡Comiste algo en mal estado! salud-15");
    salud = salud - 15;
}
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 2:
energia = energia + 30;
hambre = hambre - 10;
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
break;
case 3:

if (probabilidad >= 50)
{
    Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
    salud = salud + 10;
    Console.WriteLine("Salud: " + salud);
    Console.WriteLine("Energia: " + energia);
    Console.WriteLine("Hambre: " + hambre);
}
else
        {
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
        }

break;
case 4:
Console.WriteLine("Salud: " + salud);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Hambre: " + hambre);
while (desic == 4)
{
    Console.WriteLine("¿Qué querés hacer?");
    Console.WriteLine(" 1. Buscar comida ");
    Console.WriteLine("2. Dormir");
    Console.WriteLine("3. Explorar la isla ");
    Console.WriteLine("4. Ver estado del personaje");
    Console.WriteLine("5. Salir del juego ");
    Console.WriteLine("¿Que desea hacer ahora?");
    desic = int.Parse(Console.ReadLine());
    switch (desic)
    {
        case 1:
            hambre = hambre + 20;
            energia = energia - 15;

            if (probabilidad <= 30)
            {
                Console.WriteLine("¡Comiste algo en mal estado! salud-15");
                salud = salud - 15;
            }
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            break;
        case 2:
            energia = energia + 30;
            hambre = hambre - 10;
            Console.WriteLine("Salud: " + salud);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Hambre: " + hambre);
            break;
        case 3:

            if (probabilidad >= 50)
            {
                Console.WriteLine("¡Encontraste plantas medicinales! salud+10");
                salud = salud + 10;
                Console.WriteLine("Salud: " + salud);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Hambre: " + hambre);
            }
                    else
                    {
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Energia: " + energia);
                        Console.WriteLine("Hambre: " + hambre);
                    }

            break;
        case 5:
            Console.WriteLine("¡Adios, Gracias por jugar!");
            Console.ReadKey();
            break;
    }

}
break;
case 5:
Console.WriteLine("¡Adios, Gracias por jugar!");
Console.ReadKey();
break;

}
if (salud <= 0 || hambre <= 0 || energia <= 0)
{
Console.WriteLine("No pudiste sobrevivir... Game Over ☠️");
sigueVivo = false;
}
else
{
Console.Clear();
Console.WriteLine("Sobreviviste!");

}
if (sigueVivo == false)
{
Console.ReadKey();
}
}
Console.ReadKey();
}
}
}
