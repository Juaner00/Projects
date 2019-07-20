using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string texto1 = "medellin";

                float nrof = 0.0f;
                double nrod = 0.0d;
                int nroi = 0, caradado = 1;
                string nrotxt = "105";
                bool condicion = true;
                char caracter = 'c';
                short corto;

                //manejo de caracteres
                if (char.IsDigit(caracter)) Console.WriteLine("DIGITO");
                else if (char.IsLetter(caracter)) Console.WriteLine("LETRA");
                else if (char.IsLower(caracter)) Console.WriteLine("MINUSCULA");
                else if (char.IsUpper(caracter)) Console.WriteLine("MAYUSCULA");
                else Console.WriteLine("NO ES");
                //extraer el codigo aschii de un caracter
                nroi = (int)caracter;
                corto = (short)caracter;

                // cambio de decimal a float
                nrof = (float)nrod;
                // cambio de float a int
                nroi = (int)nrof;

                //CAMBIO DE INT A strings
                nroi = Int32.Parse(nrotxt) + 10;
                texto1 = nroi.ToString();

                //condicionales
                if (condicion) Console.WriteLine("es verdadero");
                else Console.WriteLine("falso bb");

                if (!condicion) Console.WriteLine("es verdad");
                else Console.WriteLine("falso");

                if (condicion) Console.WriteLine(1);
                else if (!condicion) Console.WriteLine(2);
                else Console.WriteLine(3);

                switch (caradado)
                {
                    case 1:Console.WriteLine("uno");
                       break;
                    case 2:Console.WriteLine("dos");
                        break;
                    case 3:Console.WriteLine("tres");
                        break;
                    case 4:Console.WriteLine("cuatro");
                        break;
                    case 5: Console.WriteLine("cinco");
                        break;
                    case 6:Console.WriteLine("seis");
                        break;

                    default: Console.WriteLine("error");
                        break;
                }

                 //MANEJO DE CICLOS
                for(int i=0; i<=5; i++)
                {
                    Console.WriteLine(i);
                }
                nroi = 5;
                while (nroi>=0) {
                    Console.WriteLine(nroi);
                    nroi--;
                }

                do
                    Console.WriteLine(nroi);
                while (nroi >= 0);


                //MANEJO DE LISTAS

                var fibnumeros = new List<int> { 0, 1, 1, 2, 3, 5, 8, 11 };
                nroi = 0;
                foreach(int i in fibnumeros)
                {
                    Console.WriteLine();
                }

                //adicionar elementos
                fibnumeros.Add(19);
                //tarea buscar numero de la lista y como eliminar elementos de la lista


                //Vectores creacion

                int[] puntuacion = new int[] { 96, 95, 92, 88 };
                string[] vectortxt = new string[100];
                string[] dias = { "lun", "mar", "mier", "jueves", "vie", "sab", "dom" };

                //recorrer vectores con for
                for(int i = 0; i<= dias.Length - 1; i++)
                {
                    Console.WriteLine(dias[i]);
                }

                //recorrer vectores con foreche
                foreach(string i in dias)
                {
                    Console.WriteLine(i);
                }

                //matriz
                int[,] matriz1 = new int[5, 5];
                int[,] matriz2 = new int[,] { { 4, 5 }, { 5, 6 } };

           
            }
            catch { }

        }
    }
}
