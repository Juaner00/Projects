using System;
using System.Collections.Generic;
					
public class CardGame
{
	static bool lose = false, segirBool = true;
	static string segir;
	static int total = 0, card;

	static  Random nextCard = new Random();

	public static void Main()
	{	
		for (int i = 0; i < 2; i++) 
		{		
			SigCard();
		}

		while (!lose && segirBool) 
		{		
			Console.WriteLine("Quieres seguir s/n");

			segir = Console.ReadLine();

			if (segir == "s") SigCard();
			else if (segir == "n") segirBool = false;
			else Console.WriteLine("Escoge una opción correcta");

			if (total > 21) 
			{
				lose = true;
				Console.WriteLine("Has perdido");
			}
		}
		Console.WriteLine("Tu puntaje total: " + total);
	}

	static void SigCard()
	{
	  card = nextCard.Next(1, 11);
	  total += card;

	  Console.WriteLine("Carta: " + card);
	  Console.WriteLine("Total: " + total + "\n");
	} 
}
