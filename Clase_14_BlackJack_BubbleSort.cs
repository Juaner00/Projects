using System;
using System.Collections.Generic;
					
public class CardGame
{
	//static bool lose = false, segirBool = true;
	static string segir;
	static int total = 0, card;

	static  Random nextCard = new Random();

	public static void Main()
	{	
    Console.Write("Cuántos jugadores van a jugar?: ");
    int nJugadores = int.Parse(Console.ReadLine());

    int[] puntajes = new int[nJugadores];
    string[] nombreJugadores = new string[nJugadores];

    for (int turno = 0; turno < nJugadores; turno++) 
    {
      Console.Write("\nNombre jugador " + (turno + 1) + "\n");
      nombreJugadores[turno] = Console.ReadLine();

      for (int i = 0; i < 2; i++) 
      {		
        SigCard();
      }

      while (true /*!lose && segirBool*/) 
      {		
        Console.WriteLine("Quieres seguir s/n");

        segir = Console.ReadLine();

        if (segir == "s") SigCard();
        else if (segir == "n") break; //segirBool = false;
        else Console.WriteLine("Escoge una opción correcta");

        if (total == 21) 
        {
          Console.WriteLine("Has obtenido un BlackJack");
          break;
        }

        if (total > 21) 
        {
          //lose = true;
          Console.WriteLine("Has perdido");
          total = 0;
          break;
        }
      }
			
      Console.WriteLine("Tu puntaje total: " + total);
      puntajes[turno] = total;
      
      total = 0;
    }

    /*int mayorPuntaje = 0;
    string nombreJ = "";
    
    for (int j = 0; j < nJugadores; j++)
    {
      if (puntajes[j] > mayorPuntaje) 
      {
        mayorPuntaje = puntajes[j];
        nombreJ = nombreJugadores[j];
      }
    }*/

    Bubble(ref puntajes, ref nombreJugadores);

    Console.WriteLine("\nEl jugador con más puntos es " + puntajes[0] + " puntaje " + nombreJugadores[0]);

	}

	static void SigCard()
	{
	  card = nextCard.Next(1, 11);
	  total += card;

	  Console.WriteLine("\nCarta: " + card);
	  Console.WriteLine("Total: " + total + "\n");
	} 

  static void Bubble(ref int[] puntaje, ref string[] nombres)
  {
    for (int i = 0; i < (puntaje.Length - 1); i++){
      for (int j = 0; j < (puntaje.Length - 1 - i); j++)
      {
        if (puntaje[j] < puntaje[j + 1]) 
        {
          int tempPuntajes = puntaje[j + 1];
          string tempNombres = nombres[j + 1];

          puntaje[j + 1] = puntaje[j];
          puntaje[j] = tempPuntajes;

          nombres[j + 1] = nombres[j];
          nombres[j] = tempNombres;
        }
      }
    }

    for (int i = 0; i < puntaje.Length; i++) 
    {  
      Console.WriteLine("\nJugador {0} puntaje {1}", nombres[i], puntaje[i]);
    }
  }
}
