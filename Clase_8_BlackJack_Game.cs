using System;
using System.Collections.Generic;
					
public class CardGame
{
	public static void Main()
	{	
    bool lose = false, segirBool = true;
    string segir;
    int total = 0, card;
    
    Random nextCard = new Random();
	    
		for (int i = 0; i < 2; i++) 
		{		
			card = nextCard.Next(1, 11);
      total += card;
    
      Console.WriteLine("Carta: " + card);
      Console.WriteLine("Total: " + total + "\n");
		}
		
		while (!lose && segirBool) 
		{		
			Console.WriteLine("Quieres seguir s/n");

			segir = Console.ReadLine();

			if (segir == "s") 
			{
				card = nextCard.Next(1, 11);
        total += card;
        
        Console.WriteLine("Carta: " + card);
        Console.WriteLine("Total: " + total + "\n");
			} 
			else if (segir == "n") 
			{
				segirBool = false;
			}
			else 
			{
				Console.WriteLine("Escoge una opción correcta");
			}

			if (total > 21) 
			{
				lose = true;
				Console.WriteLine("Has perdido");
			}
		}
		Console.WriteLine("Tu puntaje total: " + total);
	}
}
