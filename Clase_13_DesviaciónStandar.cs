using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
{
    static void Main()
    {
        Console.Write("Dame una cantidad de números: ");
        int n = int.Parse(Console.ReadLine());

        double total = 0;
        int edadMayor = 0;
        int edadMenor = 0;
        int edadPersonaProm = 0;
        string nombreEdadMayor = "";
        string nombreEdadMenor = "";
        string nombrePersonaProm = "";

        int[] edades = new int[n];
        string[] nombres = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Dame la edad " + i + ": ");
            edades[i] = int.Parse(Console.ReadLine());

            Console.Write("Dame el nombre de la persona " + i + ": ");
            nombres[i] = Console.ReadLine();

            total += edades[i];

            if (i == 0)
            {
                edadMayor = edades[i];
                nombreEdadMayor = nombres[i];
                edadMenor = edades[i];
                nombreEdadMenor = nombres[i];
            }

            if (edades[i] > edadMayor)
            {
                edadMayor = edades[i];
                nombreEdadMayor = nombres[i];
            }
            if (edades[i] < edadMenor)
            {
                edadMenor = edades[i];
                nombreEdadMenor = nombres[i];
            }
                
        }

        double prom = total / n;

        total = 0;
        for (int i = 0; i < n; i++)
        {
            total += (prom - edades[i]) * (prom - edades[i]);
        }

        //desviacion
        double desv = Math.Sqrt(total / n);

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                edadPersonaProm = edades[i];
                nombrePersonaProm = nombres[i];
            }
            if (Math.Abs(edades[i] - prom) < Math.Abs(edadPersonaProm - prom))
            {
                edadPersonaProm = edades[i];
                nombrePersonaProm = nombres[i];
            }
        }

        Console.WriteLine("Mayor: " + nombreEdadMayor + ", " + edadMayor + " años");
        Console.WriteLine("Menor: " + nombreEdadMenor + ", " + edadMenor + " años");
        Console.WriteLine("Promedio: " + prom + "\nDesviacion estandar: " + desv);
        Console.WriteLine("Nombre de la persona más cercana al promedio: " + nombrePersonaProm + "\nEdad: " + edadPersonaProm);

    }
}
