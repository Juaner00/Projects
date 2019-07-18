using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dame una frase: ");
        string frase = Console.ReadLine();
        Console.WriteLine("Dame una palabra para buscar en la frase: ");
        string word = Console.ReadLine();

        /*int contadorEspacios = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == ' ') contadorEspacios++;
        }

        string[] palabras = new string[contadorEspacios + 1];*/

        string fraseUpper = frase.ToUpper();
        string wordUpper = word.ToUpper();

        int contadorLetra = 0;
        int contadorPalabra = 0;

        for (int i = 0; i < (frase.Length - word.Length + 1); i++)
        {
            bool anterior = true;
            for (int j = 0; j < word.Length; j++)
            {
                if (fraseUpper[i + j] == wordUpper[j] && anterior)
                {
                    contadorLetra++;
                    anterior = true;
                }
                else anterior = false;
                if (contadorLetra == wordUpper.Length)
                {
                    contadorPalabra++;
                    Console.Write("posición: ");
                    for (int k = 0; k < word.Length; k++)
                    {
                        Console.Write((k + i) + ", ");
                    }
                    Console.WriteLine();
                }
            }
            if (contadorLetra == wordUpper.Length)
            {
                for (int j = 0; j < wordUpper.Length; j++)
                {
                    if (fraseUpper[i + j] == wordUpper[j]) contadorLetra++;
                }
            }
            contadorLetra = 0;
        }

        Console.WriteLine("La palabra '" + word + "' se repite " + contadorPalabra + " veces");
    }
}
