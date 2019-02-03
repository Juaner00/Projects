using System;
					
public class Triangulo2
{
	public static void Main()
	{
		Console.WriteLine("Dame los valores de la hipotenisa y de un angulo");
		double h = double.Parse(Console.ReadLine());
		double aGrados = double.Parse(Console.ReadLine());
		
		//Angulos
		double bGrados = 90;
		double cGrados = 180 - aGrados - bGrados;
		
		double aRad = aGrados * Math.PI / 180;
		double bRad = bGrados * Math.PI / 180;
		double cRad = cGrados * Math.PI / 180;
		
		//Lados
		double ca = h * Math.Sin(aRad);
		double co = h * Math.Cos(aRad);
		
		Console.WriteLine("Los valores de los lados son : " + ca + ", " + co + ", " + h);
		Console.WriteLine("Los valores de los angulos son : " + aGrados + ", " + bGrados + ", " + cGrados);
	}
}
