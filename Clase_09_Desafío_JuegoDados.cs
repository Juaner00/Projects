using System;
using System.Collections.Generic;

class Program {

  static Random dado = new Random();

  static bool ganar = false, perder = false, continuarBool = true;
  static int total = 0, dadoNext = 0, dadoPrev = 0;
  static string respuesta = "";

  static void Main() {

    for (int i = 0; i < 3; i++){
      SigDados();
    }
    
    while (!ganar && !perder && continuarBool) {
      //Continuar
      Console.Write("Desea cotinuar (s/n) ");
      respuesta = Console.ReadLine();

      if (respuesta == "s") SigDados();
      else if (respuesta == "n") continuarBool = false;
      else Console.WriteLine("Digite una opcion correcta");

      //Ganar
      if (total >= 100) {
        ganar = true;
        Console.WriteLine("Ha ganado");
      }
      else if (dadoPrev == 10 && dadoNext == 12) {
        ganar = true;
        Console.WriteLine("Ha ganado porque ha sacado un 12 despues de un 10");
      }

      //Perder
      if (dadoNext % 2 == 1) {
        perder = true;
        Console.WriteLine("Ha perdido porque ha sacado un numero impar");
      }
     
      dadoPrev = dadoNext;
    }
    //Mensaje final
    Console.WriteLine("Tu puntaje total: " + total);
  }

  static void SigDados() {
    dadoNext = dado.Next(1, 13);
    total += dadoNext;

    Console.WriteLine("dado: " + dadoNext);
    Console.WriteLine("Total: " + total + "\n");
  }
}
