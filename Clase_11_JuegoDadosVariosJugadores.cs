using System;

class MainClass 
{
  public static void Main () 
  {
    Random dado = new Random();
    int dadoSig = 0, total = 0, contadorDados = 0, jugador = 0;
    Console.Write("Cuántos jugadores van a jugar?: ");
    int nJugadores = int.Parse(Console.ReadLine());

    while(jugador < nJugadores){
      Console.WriteLine("\nJugador " + (jugador + 1));
      
      while (true){
        dadoSig = dado.Next(1, 7);
        total += dadoSig;
        Console.WriteLine("Dado: " + dadoSig);
        Console.WriteLine("Total: " + total);

        if (total >= 100) {
          Console.WriteLine("Has ganado");
          break;
        }
        if (dadoSig == 1) contadorDados++;
        else contadorDados = 0;
        if (contadorDados == 3){
          Console.WriteLine("Has perdido porque has sacado tres 1 seguidos");
          break;
        }

        Console.Write("Desea continuar? (s/n): ");
        if (Console.ReadLine() == "n") break;
      }

      Console.WriteLine("Total: " + total);
      dadoSig = 0;

      if (total >= 100) break;
      total = 0;
      jugador++;
    }
  }
}
