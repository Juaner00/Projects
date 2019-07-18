using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] coordsX = { 0, 2, 3, 7 };
        int[] coordsY = { 0, 1, 5, 6 };

        double[] pend = new double[3];
        double[] b = new double[3];

        int x = 0, y = 0;

        double[] dis = new double[3];
        double disMax = 0;
       
        for (int i = 1; i < coordsX.Length; i++)
        {
            //distancia
            dis[i-1] = Math.Sqrt(Math.Pow((coordsX[i] - coordsX[i-1]), 2) + Math.Pow((coordsY[i] - coordsY[i-1]), 2));

            if (dis[i-1] > disMax || i == 1)
            {
                disMax = dis[i-1];
                x = coordsX[i];
                y = coordsY[i];
            }

            //pend
            pend[i-1] = ((coordsX[i] - coordsX[i-1]) / coordsY[i] - coordsY[i-1]);

            //b
            b[i-1] = coordsY[i-1] - pend[i-1] * coordsY[i-1];

        }
        //misma linea recta
        for (int j = 0; j < 2; j++)
        {

            if (pend[j] != pend[j + 1] || b[j] != b[j+1])
            {
                Console.WriteLine("No pertenecen a la misma linea recta");
                break;
            } 
        }

        Console.WriteLine("La mayor distancia es: " + disMax + "\nlos puntos son x: " + x + " y: " + y);
    }
}
