using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            char[] caracteres = new char[] { 'A', 'B', 'I', 'D', '?' };

            //Valor de las letras
            int[] A = new int[] { -1,  0 };
            int[] B = new int[] {  1,  0 };
            int[] I = new int[] {  0, -1 };
            int[] D = new int[] {  0,  1 };

            Dictionary<char, int[]> desp = new Dictionary<char, int[]> { { 'A', A }, { 'B', B }, { 'I', I }, { 'D', D } };

            try
            {
                char[] texto = LeerArchivo();
                AnalizarContenido(texto, caracteres);

                AnalizarDesplazamientos(texto, desp, caracteres);

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }
        }

        private static void AnalizarContenido(char[] texto, char[] caracteres)
        {
            foreach (char dato in texto)
            {
                Console.WriteLine(dato);
                if (!caracteres.Contains(dato))
                {
                    Console.WriteLine("'{0}' No es válido", dato);
                }
            }
            if (texto.Count() < 8)
            {
                Console.WriteLine("Debe tener una longitud mayor o igual a 8 contando los interrogantes");
            }
        }

        private static void AnalizarDesplazamientos(char[] texto, Dictionary<char, int[]> desp, char[] caracteres)
        {
            int[] contador = new int[2];
            foreach (char letra in texto)
            {
                if (caracteres.Contains(letra)) {
                    int[] despLetra = desp[letra];
                    //Vertical
                    contador[0] += despLetra[0];
                    //Horizontal
                    contador[1] += despLetra[1];
                }
            }
            Console.WriteLine("Se mueve {0}, {1}", contador[1], contador[0]);
        }

        private static char[] LeerArchivo()
        {
            string renglon; //lee línea a línea el archivo
            string textoString = "";

            //Tipo de dato de archivos
            StreamReader archivo = new StreamReader("C:\\Users\\manue\\Desktop\\Ej_4.txt");

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
    }
}
