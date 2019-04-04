using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] valores = { "-", "-", "X", "O" };
        int n = 10;
        int m = 15;

        string[,] tablero = new string[n, m];
        string[,] salida = new string[n, m];

        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                int indice = random.Next(0, valores.Length);
                tablero[i, j] = valores[indice];
                salida[i, j] = "-";
            }
        }

        Console.WriteLine("ENTRADA");
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                Console.Write("|" + tablero[i, j]);
            }
            Console.Write("|\n");
        }

        Console.WriteLine("\nSALIDA");

        int n_ = 0;
        int nX = 0;
        int nO = 0;

        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                if (tablero[i, j] == "X") nX++;
                else nX = 0;
                if (tablero[i, j] == "O") nO++;
                else nO = 0;

                if (nX >= 3)
                {
                    salida[i, j] = 1.ToString();
                    salida[i, j - 1] = 1.ToString();
                    salida[i, j - 2] = 1.ToString(); 
                }
                Console.Write("|" + salida[i, j]);
            }
            nX = 0; nO = 0;
            Console.Write("|\n");
        }

        //Porcentaje
       
        nX = 0; nO = 0; n_ = 0;

        /*for (int i = 0; i < salida.GetLength(0); i++)
        {
            for (int j = 0; j < salida.GetLength(1); j++)
            {
                if (tablero[i, j] == "X") nX++;
                if (tablero[i, j] == "O") nO++;
                if (tablero[i, j] == "-") n_++;
            }
        }*/

        foreach (string celda in tablero)
        {
            if (celda == "X") nX++;
            if (celda == "O") nO++;
            if (celda == "-") n_++;
        }

        int sum = nX + nO + n_;
        double pX = nX * 100 / sum;
        double pO = nO * 100 / sum;
        double p_ = n_ * 100 / sum;

        Console.WriteLine("\nPORCENTAJE DE 'X': " + pX);
        Console.WriteLine("PORCENTAJE DE 'O': " + pO);
        Console.WriteLine("PORCENTAJE DE '-': " + p_);

        Console.WriteLine("");
    }
}
