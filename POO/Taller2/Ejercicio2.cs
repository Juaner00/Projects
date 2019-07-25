using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static string[] vocales = new string[] { "A", "E", "I", "O", "U" };
        static string[,] matrizPrueba = new string[,] { { "A", "W", "r", "t" }, { "A", "E", "i", "w" }, { "f", "U", "e", "j" }, { "l", "a", "b", "c" } };

        public static void Main(string[] args)
        {
            try
            {
                //Generar una matriz aleatoria
                string[,] matrizGeneral = GenerarMatriz();
                //string[,] matrizGeneral = matrizPrueba;

                //Imprimir la matriz
                ImpimirMatrix(matrizGeneral);

                //Crear una submatriz 2x2 y analizarla
                string[,] matriz2x2 = GenerarSubMatriz2x2(matrizGeneral);


                //Imprimir Matriz Vocales
                ImpimirMatrix(matriz2x2);

                Console.ReadKey();

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
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

                int rand1 = rand.Next(2, 11);
                int rand2 = rand.Next(2, 11);

                string[,] matrizGenerada = new string[rand1, rand2];

                for (int i = 0; i < matrizGenerada.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizGenerada.GetLength(1); j++)
                    {
                        if (rand.Next(0, 2) == 0) matrizGenerada[i, j] = letras[rand.Next(0, letras.Length)].ToUpper();
                        else matrizGenerada[i, j] = letras[rand.Next(0, letras.Length)];
                    }
                }

                return matrizGenerada;
            }
            catch (Exception error)
            {
                Console.WriteLine("Este error: ", error);
                return null;
            }
        }

        private static string[,] GenerarSubMatriz2x2(string[,] matrizGenerada)
        {
            try
            {
                string[,] matriz2x2 = new string[2, 2];
                string[,] matriz2x2Upper = new string[2, 2];

                for (int i = 0; i < matrizGenerada.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrizGenerada.GetLength(1) - 1; j++)
                    {
                        for (int k = 0; k <= 1; k++)
                        {
                            for (int h = 0; h <= 1; h++)
                            {
                                matriz2x2[k, h] = matrizGenerada[k + i, h + j];
                                matriz2x2Upper[k, h] = matrizGenerada[k + i, h + j].ToUpper();
                            }
                        }
                        //Analizar la nueva matriz 2x2
                        //ImpimirMatrix(matriz2x2);
                        if (AnalizarMatriz2x2(matriz2x2Upper)) return matriz2x2;
                    }
                }
                return null;
            }
            catch (Exception error)
            {
                Console.WriteLine("error: ", error);
                return null;
            }
        }

        private static bool AnalizarMatriz2x2(string[,] matriz)
        {
            int contador = 0;
            bool contVocal = false;
            string[] vocalesUpper = new string[vocales.Length];

            for (int i = 0; i < vocales.Length; i++)
            {
                vocalesUpper[i] = vocales[i].ToUpper();
            }

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    if (vocalesUpper.Contains(matriz[i, j]))
                    {
                        contVocal = true;
                        contador++;
                    }
                    else
                    {
                        contVocal = false;
                        break;
                    }
                }
                if (!contVocal) break;
            }
            if (contador == 4)
            {
                Console.WriteLine("\nEncontrado\n");
                return true;
            }
            else return false;
        }

        private static void ImpimirMatrix(string[,] matriz)
        {
            //Imprimir la matriz
            if (matriz != null)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nNo encontrado\n");
            }
        }
    }
}
