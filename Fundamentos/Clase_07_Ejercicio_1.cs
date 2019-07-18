using System;
					
public class Program
{
	public static void Main()
	{
		int mayor = 0, menor = 0, edad = 0; i = 0, total = 0;
		
		string nombre = "", nMayor = "", nMenor = "";
    
		double promedio = 0;
		
		Console.WriteLine("Cantidad de datos que va a ingresar");
		int nDatos = int.Parse(Console.ReadLine());
		
		while (i < nDatos){
			
			Console.WriteLine("Cual es tu nombre?");
			nombre = Console.ReadLine();
			
			Console.WriteLine("Cual es tu edad?");
			edad = int.Parse(Console.ReadLine());
			
			total += edad;
      
      if(i == 0){
        mayor = edad;
        menor = edad;
      }
			if (edad > mayor){
				mayor = edad;
				nMayor = nombre;
			}else if (edad < menor) {
				menor = edad;	
				nMenor = nombre;
			}
			i++;
		}
		
		promedio = total / nDatos;
		Console.WriteLine("Promedio: " + promedio);
		Console.WriteLine("Mayor: " + nMayor + " " + mayor);
		Console.WriteLine("Menor: " + nMenor + " " + menor);
	}
}
