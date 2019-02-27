using System;
using System.Collections.Generic;

class Program 
{
  static Random dado = new Random();

  static bool perder = false, continuarBool = true;
  static int total = 0, vida = 3, turno = 0, dado1 = 0, dado2 = 0;
  static string respuesta = "";

  static void Main() 
  {
    Console.WriteLine("Pierdes una vida cada dos turnos");
    Console.WriteLine("Cada tres turnos lanzan dos dados, si éstos son iguales ganas una vida\n");
    Console.WriteLine("Tus vidas: " + vida);

    ++turno;
    Console.WriteLine("\nTurno: " + turno + "\n");
    SigDados(1);
    
    while (!perder && continuarBool) 
    {
      //Continuar
      Console.Write("Desea cotinuar (s/n) ");
      respuesta = Console.ReadLine();

      switch (respuesta)
      {
        case "s":
          continuarBool = true;
          ++turno;
          Console.WriteLine("\nTurno: " + turno + "\n");
          break;
        case "n":
          continuarBool = false;
          break;
        default:
          Console.WriteLine("Digite una opcion correcta");
          continue;
      }

      //Dobles dados, cada 3 turnos
      if(turno % 3 == 0 && continuarBool) 
      {
        Console.WriteLine("Lanzas dos dados cada tres turnos");
        SigDados(2);

        //Ganar vida
        if (dado1 == dado2) 
        {
          vida++;
          Console.WriteLine("Has ganado una vida");
          Console.WriteLine("Tus vidas: " + vida);
        }

      } else if (continuarBool) SigDados(1);

      //Perder vida
      if (turno % 2 == 0 && continuarBool) 
      {
        vida -= 1;
        Console.WriteLine("Has perdido una vida. Vidas restantes: " + vida);
      }

      //Perder juego
      if (vida == 0) 
      {
        perder = true;
        Console.WriteLine("Tus vidas: " + vida);
        Console.WriteLine("Has perdido porque te has quedado sin vidas");
      }
    
    }
    //Mensaje final
    Console.WriteLine("\nTu puntaje total: " + total);
  }

  //Lanzar dados
  static void SigDados(int dados) 
  {
    switch (dados)
    {
      case 1:
        dado1 = dado.Next(1, 7);
        total += dado1 + dado2;

        Console.WriteLine("Dado 1: " + dado1);
        Console.WriteLine("Total: " + total + "\n");
        break;
      case 2:
        dado1 = dado.Next(1, 7);
        dado2 = dado.Next(1, 7);
        total += dado1 + dado2;

        Console.WriteLine("Dado 1: " + dado1);
        Console.WriteLine("Dado 2: " + dado2);
        Console.WriteLine("Total: " + total + "\n");
        break;
    } 
  }
}
