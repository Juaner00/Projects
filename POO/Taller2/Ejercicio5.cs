using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Taller2
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                LeerArchivo();
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        private static void AlcanzarEnemigo()
        {

        }

        private static void LeerArchivo()
        {
            string linea; //lee línea a línea el archivo
            string[] renglones;

            //Tipo de dato de archivos
            StreamReader archivo = new StreamReader("C:\\Users\\manue\\Desktop\\Matriz.txt");

            //Poner las líneas en el archivo
            linea = archivo.ReadLine();

            //Recorrer el archivo
            while (linea != null)
            {
                //Dividir la linea en ese carácter
                renglones = linea.Split('\n');
                Console.WriteLine("La capital de: {0} es: {1}", renglones[0], renglones[1]);
                //leer la proxima linea
                linea = archivo.ReadLine();
            }
            archivo.Close();
        }
    }
}