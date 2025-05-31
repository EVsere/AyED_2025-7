using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Después de unas largas vacaciones llenas de aventuras, Phineas y Ferb regresan a la escuela. Sin embargo, como no estudiaron durante las vacaciones, necesitan un sistema que les ayude a determinar si podrán aprobar la materia.
El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos (TPs) y exámenes que tienen en la materia. Luego, deben ingresar las notas de cada TP y examen.
Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
El promedio de las notas de los exámenes debe ser mayor o igual a 6.
Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
El sistema debe calcular el promedio de los exámenes y verificar si se cumplen las condiciones para aprobar la materia. Finalmente, debe mostrar en pantalla un mensaje indicando si Phineas y Ferb pueden aprobar la materia o no.
Permitir al usuario especificar la cantidad de TPs y exámenes.
Permitir al usuario ingresar las notas de cada TP y examen.
Calcular el promedio de las notas de los exámenes.
Verificar si se cumplen las condiciones para aprobar la materia.
Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia.*/

            //cant tps
            //condi: promedio>6, 75% aprob
            //promedio
            // mostrar si ap o no


            //ingresar cant tps y llenarlo... no es dificil de entender
            //no se pq hago esto
            //me gusta programar
            //hola profe

            Console.WriteLine("Cuantos tps hiciero en el año?");
            int tps = int.Parse(Console.ReadLine());
            int[] notas = new int[tps];
            int promedio = 0;
            int aprobados = 0;
            double promap = 0;

            for (int i = 0; i < tps; i++)
            {
                Console.WriteLine("Cual esla nota del tp" + (i+1) + "?");
                notas[i] = int.Parse(Console.ReadLine());

                //promedio
                promedio = (notas[i] + promedio) / tps;

                //ap
                if (notas[i] >= 6)
                {
                    aprobados++;
                }
                //el 75% de tps seria multiplicarlo por 0.75
                promap = tps * 0.75;

                //condi of ap
                
            }

            if (promedio > 6 && aprobados >= promap)
            {
                Console.WriteLine("Aprobaste la materia!");
            }
            else
            {
                Console.WriteLine("No aprobaste la materia!");
            }

            Console.ReadKey();


        }
    }
}
