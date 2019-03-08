using System;
					
public class Tarifas
{
	public static void Main()
	{
		Console.WriteLine("Dame tus ingresos mensuales");
		double ingresos = double.Parse(Console.ReadLine());
		double smmlv = 828116;
		double smmldv = 27604;
		double tarifaA = 0.117 * smmldv;
		double tarifaB = 0.461 * smmldv;
		double tarifaC = 1.215 * smmldv;
		
		if (ingresos < smmlv * 2){
			
			Console.WriteLine("Tarifa A");
			Console.WriteLine(tarifaA);
			
		}else if (ingresos >= smmlv * 2 && ingresos < smmlv * 5){	
			
			Console.WriteLine("Tarifa B");
			Console.WriteLine(tarifaB);
			
		}else{
			
			Console.WriteLine("Tarifa C");
			Console.WriteLine(tarifaC);
		
		}
	}
}
