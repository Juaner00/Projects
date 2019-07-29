using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio5
{
    class Ejercicio5
    {
        public static void Main(string[] args)
        {
            AlcanzarEnemigo();
        }

        private static void AlcanzarEnemigo()
        {
            try
            {
                char[] charValidos = { 'X', 'O', 'Y' };

                int[] posX = new int[2];

                //Leer archivo y crear lista
                string[] renglonesArray = LeerArchivoYCrearLista();

                //Crear e imprimir matriz
                char[,] matriz = CrearMatriz(renglonesArray);
                ImprimirMatriz(matriz);

                //Analizar que tenga al menos una X y una Y
                AnalizarDatosMatriz(matriz, charValidos);

                //Crear un diccionario con la pos de X y Y
                Dictionary<char, int[]> datoPos = CrearObjPos(matriz, ref posX);

                //Calcular distancias
                int[] direccion = CalcularDistancia(datoPos, matriz);

                MoverX(matriz, direccion, ref posX);

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        private static string[] LeerArchivoYCrearLista()
        {
            string renglon; //lee línea a línea el archivo
            List<string> renglonesLista = new List<string>();

            //Tipo de dato de archivos
            StreamReader archivo = new StreamReader("C:\\Users\\manue\\Desktop\\Matriz.txt");

            //Poner las líneas en el archivo
            renglon = archivo.ReadLine();

            //Recorrer el archivo
            while (renglon != null)
            {
                //Añadir los renglones a una lista de renglones
                renglonesLista.Add(renglon.ToUpper());

                //leer la proxima linea
                renglon = archivo.ReadLine();
            }
            archivo.Close();

            return renglonesLista.ToArray();
        }

        private static char[,] CrearMatriz(string[] renglonesArray)
        {
            char[,] matriz = new char[renglonesArray.Length, renglonesArray[0].Length];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string renglon = renglonesArray[i];
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = renglon[j];
                }
            }
            return matriz;
        }

        private static void AnalizarDatosMatriz(char[,] matriz, char[] charValidos)
        {
            int contX = 0;
            int contY = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (!charValidos.Contains(matriz[i, j]))
                    {
                        Console.WriteLine("Se esperaban X, O, Y");
                        break;
                    }
                    if (matriz[i, j] == 'X') contX++;
                    else if (matriz[i, j] == 'Y') contY++;
                }
            }
            if (contX != 1) Console.WriteLine("Debe haber sólo una X");
            else if (contY < 1) Console.WriteLine("Debe haber mínimo una Y");
        }

        private static Dictionary<char, int[]> CrearObjPos(char[,] matriz, ref int[] posX)
        {
            Dictionary<char, int[]> posDatos = new Dictionary<char, int[]>();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 'X')
                    {
                        posX = new int[] { i, j };

                        int[] pos = new int[] { i, j };
                        posDatos.Add(matriz[i, j], pos);
                    }
                    if (matriz[i, j] == 'Y')
                    {
                        int[] pos = new int[] { i, j };
                        posDatos.Add(matriz[i, j], pos);
                    }
                } 
            }
            return posDatos;
        }

        private static int[] CalcularDistancia(Dictionary<char, int[]> objetos, char[,] matriz)
        {
            int[] direccion = new int[2];

            int row = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            int[] xPos = objetos['X'];
            int[] yPos = objetos['Y'];

            //Calcular distancias, por iz, por der
            int disIz = xPos[1] + 1 + (col - 1 - yPos[1]);
            int disDr = Math.Abs(xPos[1] - yPos[1]);

            //Calcular distancias, por ar, por ab
            int disAr = xPos[0] + 1 + (row - 1 - yPos[0]);
            int disAb = Math.Abs(xPos[0] - yPos[0]);

            if (disIz < disDr)
            {
                direccion[1] = -disIz;
            }
            else
            {
                direccion[1] = disDr;
            }
            if (disAr < disAb)
            {
                direccion[0] = -disAr;
            }
            else
            {
                direccion[0] = -disAb;
            }

            Console.WriteLine("Cantidad de pasos: {0}", (Math.Abs(direccion[0]) + Math.Abs(direccion[1])));

            return direccion;
        }

        private static void MoverX(char[,] matriz, int[] dir, ref int[] posX)
        {
            //Mover izquierda
            if (dir[1] < 0)
            {
                for (int i = dir[1]; i < 0; i++)
                {
                    //Si está en el borde, rodea el tablero
                    if (posX[1] == 0)
                    {
                        Console.WriteLine();

                        Console.WriteLine("Mover izquierda");

                        matriz[posX[0], posX[1]] = 'O';

                        posX[1] += matriz.GetLength(1) - 1;
                        matriz[posX[0], posX[1]] = 'X';

                        ImprimirMatriz(matriz);
                    }
                    //Se mueve 1 a la izquierda
                    else
                    {
                        Console.WriteLine();

                        Console.WriteLine("Mover izquierda");

                        matriz[posX[0], posX[1]] = 'O';

                        posX[1] += -1;
                        matriz[posX[0], posX[1]] = 'X';

                        ImprimirMatriz(matriz);
                    }
                }
            }
            //Mover derecha
            else if (dir[1] > 0)
            {
                for (int i = dir[1]; i > 0; i--)
                {
                    Console.WriteLine();
                    //Se mueve 1 a la derecha
                    Console.WriteLine("Mover derecha");

                    matriz[posX[0], posX[1]] = 'O';

                    posX[1] += 1;
                    matriz[posX[0], posX[1]] = 'X';

                    ImprimirMatriz(matriz);
                }
            }

            //Mover arriba
            if (dir[0] < 0)
            {
                for (int i = dir[0]; i < 0; i++)
                {
                    //Si está en el borde, rodea el tablero
                    if (posX[0] == 0)
                    {
                        Console.WriteLine();

                        Console.WriteLine("Mover arriba");

                        matriz[posX[0], posX[1]] = 'O';

                        posX[0] += matriz.GetLength(0) - 1;
                        matriz[posX[0], posX[1]] = 'X';

                        ImprimirMatriz(matriz);
                    }
                    //Se mueve 1 a arriba
                    else
                    {
                        Console.WriteLine();

                        Console.WriteLine("Mover arriba");

                        matriz[posX[0], posX[1]] = 'O';

                        posX[0] += -1;
                        matriz[posX[0], posX[1]] = 'X';

                        ImprimirMatriz(matriz);
                    }
                }
            }
            //Mover abajo
            else if (dir[1] > 0)
            {
                for (int i = dir[0]; i > 0; i--)
                {
                    Console.WriteLine();
                    //Se mueve 1 abajo
                    Console.WriteLine("Mover abajo");

                    matriz[posX[0], posX[1]] = 'O';

                    posX[0] += 1;
                    matriz[posX[0], posX[1]] = 'X';

                    ImprimirMatriz(matriz);
                }
            }
        }

        private static void ImprimirMatriz(char[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j].ToString(), " ");
                }
                Console.WriteLine();
            }
        }
    }
}