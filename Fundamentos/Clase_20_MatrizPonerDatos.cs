using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ALTO de la matriz: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el ANCHO de la matriz: ");
        int m = int.Parse(Console.ReadLine());

        string[,] tablero = new string[n, m];

        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                tablero[i, j] = "-";
            }
        }

        Console.WriteLine("\nEntrada");

        Print(tablero);

        Console.Write("\nDigita la posicion (horizontal) en donde quieres poner una 'X': ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("\nDigita la posicion (vertical) en donde quieres poner una 'X': ");
        int y = int.Parse(Console.ReadLine());

        while (true)
        {
            if (tablero[x, y] == "-")
            {
                tablero[x, y] = "X";
                Print(tablero);
            }
            else Console.WriteLine("\nPrueba en otro sitio");
            Console.WriteLine("\nQuieres seguir (s/n)");
            string resp = Console.ReadLine();
            if (resp == "n") break;
            Console.Write("\nX: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("\nY: ");
            y = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nAsí quedó el tablero\n");
        Print(tablero);
    }

    private static void Print(string[,] tablero)
    {
        Console.Write("\n");
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                Console.Write("|" + tablero[i, j]);
            }
            Console.Write("|\n");
        }
    }
}
