using System;
					
public class Triangulo1
{
	public static void Main()
	{
		Console.WriteLine("Dame los valores de los dos catetos de un triangulo rectangulo");
		double ca = double.Parse(Console.ReadLine());
		double co = double.Parse(Console.ReadLine());
		
		//Pitagoras
		double h = Math.Sqrt(ca * ca + co * co);
		
		//Angulos
		double a = 90;
		double b = (Math.Atan(co / ca) * 180 / Math.PI);
		double c = (Math.Atan(ca / co) * 180 / Math.PI);
		
		Console.WriteLine("Los valores de los lados son : " + ca + ", " + co + ", " + h);
		Console.WriteLine("Los valores de los angulos son : " + a + ", " + b + ", " + c);
	}
}
