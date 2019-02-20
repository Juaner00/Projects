using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {

    static Random dado = new Random();

    static bool dosUno = false, ganar = false, perder = false, continuarBool = true;
    static int total = 0, dado1, dado2, pares = 0, turnos = 0;
    static double dadosSeis = 0;
    static string respuesta = "";

    static void Main() {

        SigDados();

        while (!ganar && !perder && continuarBool && !dosUno) {

            Console.Write("Desea cotinuar (s/n) ");
            respuesta = Console.ReadLine();

            if (respuesta == "s") SigDados();
            else if (respuesta == "n") continuarBool = false;
            else Console.WriteLine("Digite una opcion correcta");

            if (total >= 100) {
                ganar = true;
                Console.WriteLine("Ha ganado");
            }
            if (dado1 == 1 && dado2 == 1 && pares != 2) {
                perder = true;
                Console.WriteLine("Ha ganado");
            }
            if (dado1 == dado2) pares++;
            else pares = 0;

            if (pares == 3) {
                ganar = true;
                Console.WriteLine("Ha ganado");
            }
        }

        Console.WriteLine("Tu puntaje total: " + total);
        Console.WriteLine("Porcentaje suma de dados mayor a seis: " + (dadosSeis * 100 / turnos));
        Console.ReadLine();
    }

    static void SigDados() {
        dado1 = dado.Next(1, 11);
        dado2 = dado.Next(1, 11);
        total += dado1 + dado2;

        Console.WriteLine("dado 1: " + dado1);
        Console.WriteLine("dado 2: " + dado2);
        Console.WriteLine("Total: " + total + "\n");

        if (dado1 + dado2 > 6) dadosSeis += 1;

        turnos++;
    }
}
