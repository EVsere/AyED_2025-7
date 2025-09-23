using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc7_tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
              
                Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
                // 1) Generar mano aleatoria
                string[] mano = GenerarManoAleatoria();
                // 2) Determinar tipo de mano
                string tipo = TipoDeMano(mano);
                // 3) Calcular puntaje 
                int basePts = PuntajeBase(mano);
                // 4) Obtener multiplicador
                double mult = Multiplicador(tipo);
                // 5) Calcular puntaje final
                double total = basePts * mult;
                // 6) Aplicar jokers
                bool jokerX2 = true;
                bool jokerMas10 = true;
                total = AplicarJokers(total, jokerX2, jokerMas10);
                // 7) Mostrar resumen final
                MostrarResumen(mano, tipo, basePts, mult, total);
            }
        }

    }
}
