using System;
					
public class Boolean
{
	public static void Main()
	{
		Console.WriteLine("Numero de votos por le partido 1");
		int a = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos por le partido 2");
		int b = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos por le partido 1 en blanco");
		int blancos = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos anulados");
		int anulados = int.Parse(Console.ReadLine());
		
		Console.WriteLine("numero de la poblacion de todas las edades");
		int n = int.Parse(Console.ReadLine());
		
		Console.WriteLine("porcentaje de la poblacion que es mayor de edad");
		double p = double.Parse(Console.ReadLine());
		
		double mayor = n * (p / 100);
		int mayorInt = (int)Math.Round(mayor);
		
		double t = ((a + b) * 30 / 100);
		int tInt = (int)Math.Round(t);
		
		double nVotantes = a + b + blancos + anulados;
		
		double abstencion = mayorInt - nVotantes;
		
		Console.WriteLine("");
		Console.WriteLine("Poblacion mayor de edad: " + mayorInt);
		Console.WriteLine("Total votantes: " + nVotantes);
		Console.WriteLine("Abstencion: " + abstencion);
		
		if ((anulados < tInt || (a + b) > blancos) && abstencion < nVotantes){
		
			Console.WriteLine("");
			Console.WriteLine("Las votaciones fueron exitosas");
			if (a > b) Console.WriteLine("Ganador Partido1");
			else if (a < b) Console.WriteLine("Ganador Partido2");
			else Console.WriteLine("Ambos partidos obtuvieron la misma cantidad de votos");
			
		} else {
		
			Console.WriteLine("");
			Console.WriteLine("Las elecciones deben realizarse nuevamente");
			
		}
	}
}
