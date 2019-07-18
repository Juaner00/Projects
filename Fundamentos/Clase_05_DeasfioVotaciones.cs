using System;
					
public class Boolean
{
	public static void Main()
	{
		Console.WriteLine("Numero de votos por le partido 1");
		int a = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos por le partido 2");
		int b = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos en blanco");
		int blancos = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Numero de votos anulados");
		int anulados = int.Parse(Console.ReadLine());
		
		Console.WriteLine("numero de la poblacion de todas las edades");
		int n = int.Parse(Console.ReadLine());
		
		Console.WriteLine("porcentaje de la poblacion que es mayor de edad");
		double p = double.Parse(Console.ReadLine());
		
		double mayor = n * (p / 100);
		int mayorInt = (int)Math.Round(mayor);
		
		double treinta = (n * 30 / 100);
		int treintaInt = (int)Math.Round(treinta);
		
		double nVotantes = a + b + blancos + anulados;
		
		double abstencion = mayorInt - nVotantes;
		
		bool diferencia = false;
		
		if (Math.Abs(a - b) < nVotantes * 0.1) diferencia = true;
		
		Console.WriteLine("");
		Console.WriteLine("Poblacion mayor de edad: " + mayorInt);
		Console.WriteLine("Total votantes: " + nVotantes);
		Console.WriteLine("Abstencion: " + abstencion);
		
		if (!((nVotantes >= n || diferencia) && nVotantes <= treintaInt)){
		
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
