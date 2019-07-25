using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso de los archivos
using System.IO;

namespace Class_04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Trabajar con archivos

                string linea; //lee línea a línea el archivo
                string[] capitales;

                //Tipo de dato de archivos
                StreamReader archivo = new StreamReader("C:\\Users\\ESTUDIANTES\\Desktop\\TextoParaClass_04.txt");

                //Poner las líneas en el archivo
                linea = archivo.ReadLine();

                //Recorrer el archivo
                while (linea != null)
                {
                    //Dividir la linea en ese carácter
                    capitales = linea.Split('-');
                    Console.WriteLine("La capital de: {0} es: {1}", capitales[0], capitales[1]);
                    //leer la proxima linea
                    linea = archivo.ReadLine();
                }

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
