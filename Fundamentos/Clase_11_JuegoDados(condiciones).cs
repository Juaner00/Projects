using System;

class MainClass 
{
  public static void Main () 
  {
    Random dado = new Random();
    int dadoSig = 0, total = 0, contadorDados = 0, jugador = 0, nJugadores = 0;
    string resp = "";
    bool ganar = false;

    while (true){
      Console.Write("Cuántos jugadores van a jugar?: ");
      nJugadores = int.Parse(Console.ReadLine());
      if (nJugadores >=2 && nJugadores <=5) break;
    }
    
    while(jugador < nJugadores && !ganar){
      Console.WriteLine("\nJugador " + (jugador + 1));
      
      while (true){
        dadoSig = dado.Next(1, 7);
        total += dadoSig;
        Console.WriteLine("\nDado: " + dadoSig);
        Console.WriteLine("Total: " + total);

        if (total >= 100) {
          Console.WriteLine("Has ganado");
          ganar = true;
          break;
        }
        if (dadoSig == 1) contadorDados++;
        else contadorDados = 0;
        if (contadorDados == 3){
          Console.WriteLine("Has perdido porque has sacado tres 1 seguidos");
          break;
        }

        while (true){
          Console.Write("\nDesea continuar? (s/n): ");
          resp = Console.ReadLine();
          if (resp == "n") break;
          else if (resp == "s") break;
        }  
        if (resp == "n") break;
      }

      Console.WriteLine("Total: " + total);
      dadoSig = 0;

      total = 0;
      jugador++;
    }
  }
}
