using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Generar una matriz aleatoria
                string[,] matrizGeneral = GenerarMatriz();
                //Imprimir la matriz
                ImpimirMatrix(matrizGeneral);

                //Analizar si hay un 2x2 de sólo vocales
                string[] vocales = new string[] { "A", "E", "I", "O", "U" };

                int contador = 0;
                int buenas = 0;

                for (int i = 0; i < matrizGeneral.GetLength(0) - 2 ; i++)
                {
                    for (int j = 0; j < matrizGeneral.GetLength(1) - 2; j++)
                    {
                        
                        for (int k = 0; k <= 2; k++)
                        {
                            if (matrizGeneral[i, j].ToUpper() == vocales[k])
                            {
                                buenas++;
                                break;
                            }

                        }
                        if (buenas == 4)
                        {
                            Console.WriteLine("Si hay");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No hay");
                            contador++;
                        }
                    }
                    
                }
                Console.WriteLine(contador);

                Console.ReadKey();

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        private static string[,] GenerarMatriz()
        {
            try
            {
                //Letras
                string[] letras = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                //Generar la matiz con letras aleatorias
                Random rand = new Random();

                string[,] matriz = new string[rand.Next(2, 11), rand.Next(2, 11)];

                for (int i = 0; i < matriz.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matriz.GetLength(1) - 1; j++)
                    {
                        
                        if (rand.Next(0, 2) == 0) matriz[i, j] = letras[rand.Next(0, letras.Length)].ToUpper();
                        else matriz[i, j] = letras[rand.Next(0, letras.Length)];
                    }
                }
                
                return matriz;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return null;
            }
        }

        private static void ImpimirMatrix(string[,] matriz)
        {
            //Imprimir la matriz
            for (int i = 0; i < matriz.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matriz.GetLength(1) - 1; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
