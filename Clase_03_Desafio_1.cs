using System;
					
public class Tarifas
{
	public static void Main()
	{
		Console.WriteLine("Dame tus ingresos mensuales");
		double ingresos = double.Parse(Console.ReadLine());
		double smmlv = 828116;
		
		if (ingresos < smmlv * 2){
			
			Console.WriteLine("Tarifa A");
			
		}else if (ingresos >= smmlv * 2 && ingresos < smmlv * 4){	
			
			Console.WriteLine("Tarifa B");
			
		}else{
			
			Console.WriteLine("Tarifa C");
		
		}
	}
}
