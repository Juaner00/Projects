using System;
					
public class Triangulo2
{
	public static void Main()
	{
		Console.WriteLine("Dame los valores del cateto opuesto y de un angulo");
		double co = double.Parse(Console.ReadLine());
		double aGrados = double.Parse(Console.ReadLine());
		
		//Angulos
		double bGrados = 90;
		double cGrados = 180 - aGrados - bGrados;
		
		double aRad = aGrados * Math.PI / 180;
		double bRad = bGrados * Math.PI / 180;
		double cRad = cGrados * Math.PI / 180;
		
		//Lados
		double ca = co / Math.Tan(aRad);
		double h = co / Math.Sin(aRad);
		
		Console.WriteLine("Los valores de los lados son : " + ca + ", " + co + ", " + h);
		Console.WriteLine("Los valores de los angulos son : " + aGrados + ", " + bGrados + ", " + cGrados);
	}
}
