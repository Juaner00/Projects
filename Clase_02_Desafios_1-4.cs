using System;
					
public class Triangulos
{
	public static void Main()
	{
		Console.WriteLine("Escoge del 1 al 3 segun los datos que vas a ingresar");
		Console.WriteLine("1: b, z, y \n2: d, b, y \n3: w, d, x \n4: w, t, c");
		int n = int.Parse(Console.ReadLine()); 
		
		double a = 0;
		double b = 0;
		double c = 0;
		double d = 0;
		double t = 0;
		double g = 90;
		double h = 0;
		double w = 0;
		double x = 0;
		double y = 0;
		double z = 0;
		
		if (n == 1){
			
			Console.WriteLine("Dale el valor de b, z, y");
			
			b = double.Parse(Console.ReadLine());
			z = double.Parse(Console.ReadLine());
			y = double.Parse(Console.ReadLine());
			
			//pitagpras
			t = Math.Sqrt(z * z + y * y);
			
			//angulos
			c = Math.Atan(z / y) * Math.PI / 180;
			a = 180 - g - c;
			h = b + a;
			
			//lados
			w = z / Math.Cos(h);
			
			x = Math.Sqrt((t * t) + (w * w) - (2 * t * w * Math.Cos(h)));
			
			Console.WriteLine("El valor de x es : " + x);
			
		} else if (n == 2){
			
			Console.WriteLine("Dale el valor de d, b, y");
			
			d = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			y = double.Parse(Console.ReadLine());
			
			//angulos
			a = (180 - g - d - b) * Math.PI / 180;
			
			//lados
			z = y / Math.Tan(a);
			
			Console.WriteLine("El valor de z es : " + z);
			
		} else if (n == 3){
			
			Console.WriteLine("Dale el valor de w, d, x");
			
			w = double.Parse(Console.ReadLine());
			d = double.Parse(Console.ReadLine());
			x = double.Parse(Console.ReadLine());

			//lados
			t = Math.Sqrt((w * w) + (x * x) - (2 * w * x * Math.Cos(d * Math.PI / 180)));
			Console.WriteLine(t);
			z = w * Math.Sin(d * Math.PI / 180);			
			
			//angulos
			a = Math.Acos(z / t);
			
			//ultimo lado
			y = z * Math.Tan(a);
			
			Console.WriteLine("El valor de y es : " + y);
			
		} else if (n == 4){
		
			Console.WriteLine("Dale el valor de w, t, c");
			
			w = double.Parse(Console.ReadLine());
			t = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());
			
			//lados
			z = t * Math.Sin(c * Math.PI / 180);
			
			//angulos
			a = Math.Acos(z / t);
			h = Math.Acos(z / w);
			b = h - a;
			
			//ultimo lado
			x = Math.Sqrt((w * w) + (t * t) - (2 * w * t * Math.Cos(b)));
			
			Console.WriteLine("El valor de x es : " + x);
			
		}else {
			
			Console.WriteLine("Ingresa un valor valido");
		}
	}
}
