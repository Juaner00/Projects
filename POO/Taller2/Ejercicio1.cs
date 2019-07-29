using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1
{
    class Ejercicio1
    {
        public static void Main(string[] args)
        {
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            try
            {
                //Leer archivo y crear array
                char[] textoChar = LeerArchivo();

                //Imprimir resultado de analizar el array
                Console.WriteLine(AnalizarArray(textoChar, numeros));

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        private static char[] LeerArchivo()
        {
            string renglon; //lee línea a línea el archivo
            string textoString = "";

            //Tipo de dato de archivos
            StreamReader archivo = new StreamReader("C:\\Users\\manue\\Desktop\\Ej_1.txt");

            //Poner las líneas en el archivo
            renglon = archivo.ReadLine();

            //Recorrer el archivo
            while (renglon != null)
            {
                //Añadir los renglones a una lista de renglones
                textoString += renglon.ToUpper();

                //leer la proxima linea
                renglon = archivo.ReadLine();
            }
            archivo.Close();

            return textoString.ToCharArray();
        }

        private static bool AnalizarArray(char[] texto, char[] numeros)
        {
            int contInt = 0;
            int sumaNum = 0;
        
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == '?') contInt++;

                if (numeros.Contains(texto[i]))
                {
                    sumaNum += int.Parse(texto[i].ToString());

                    if (sumaNum == 10 && contInt == 3) return true;
                    else sumaNum = int.Parse(texto[i].ToString());

                    contInt = 0;
                }
            }
            return false;
        }

    }
}
 