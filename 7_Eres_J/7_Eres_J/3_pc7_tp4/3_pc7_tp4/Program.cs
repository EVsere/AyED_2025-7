using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc7_tp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
            bool ok = Level1.ValidateAccessKey("WD-700000")
                      && !Level1.ValidateAccessKey("WD-123123")
                      && !Level1.ValidateAccessKey("WX-000007")
                      && !Level1.ValidateAccessKey("WD-00007");
            if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
            else Console.WriteLine("🔒 LOCKED");
            



            Console.WriteLine("Nivel 2 – Ping Check (LITE)");
            int[] p = { 13, 250, -5, 40, 40, 40, 100, 205, 100 }; // válidos: 13, 40, 100 en idx 0,3,6
            int s = Level2.SumValidEveryThird(p);
            ok = s == (13 + 40 + 100); // 153
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -ACCESS" : "🔒 LOCKED");




            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
             ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
            


            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
             ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");


            Console.ReadKey();
        }
    }


    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                char next = (char)(c + 1);



                if (char.IsLower(c))
                {
                    int pos = c - 'a';
                    pos = (pos + 1) % 26;
                    char nueva = (char)('a' + pos);
                    result += nueva;
                }

                if (char.IsUpper(c))
                {
                    int pos = c - 'A';
                    pos = (pos + 1) % 26;
                    char nueva = (char)('A' + pos);
                    result += nueva;
                }



                // TODO: implementar
                // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
                // <- reemplazar por tu solución
            }
            return result;
        }
    }


        static class Level3
        {
            public static int CountAdjacent(int[,] grid, int row, int col)
            {
                int rows = grid.GetLength(0);
                int cols = grid.GetLength(1);
                int cont = 0;
                if (row - 1 >= 0 && grid[row - 1, col] == 1)
                {
                    cont++;
                }

                if (row + 1 < rows && grid[row + 1, col] == 1)
                {
                    cont++;
                }

                if (col - 1 >= 0 && grid[row, col - 1] == 1)
                {
                    cont++;
                }

                if (col + 1 < cols && grid[row, col + 1] == 1)
                {
                    cont++;
                }
                // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
                // Devolver cuántos valen 1
                return cont; // <- reemplazar por tu solución
            }
        }





        static class Level2
        {
            // Sumar p[i] para i % 3 == 0, solo si 0 <= p[i] <= 200
            public static int SumValidEveryThird(int[] p)
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (i % 3 == 0)
                    {
                        if (0 <= p[i] && p[i] <= 200)
                        {
                            sum += p[i];
                        }
                    }
                }
                return sum;
            }
        }


        static class Level1
        {
            // Debe devolver true solo si:
            // - Empieza por "WD-"                                    ya ta
            // - Luego hay exactamente 6 dígitos                      ya ta
            // - La suma de esos 6 dígitos es múltiplo de 7           ya ta
            public static bool ValidateAccessKey(string key)
            {
                if (key.Length != 9)
                {
                    return false;
                }
                if (!key.StartsWith("WD-"))
                {
                    return false;
                }
                int suma = 0;
                for (int i = 3; i < key.Length; i++)
                {
                    char c = key[i];
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }

                    int numero = c - '0';
                    suma += numero;

                }
                if (suma % 7 != 0)
                {
                    return false;
                }
                return true; // <- reemplazar por tu solución
            }
        }
    
    }

