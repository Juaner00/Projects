using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Manejo de archivos
                //Listas
                //Subrutinas


                List<string> listaJuegos = new List<string>();

                //Adicionar
                listaJuegos.Add("Farcry");
                listaJuegos.Add("Minecraft");
                listaJuegos.Add("GTAIV");
                listaJuegos.Add("CS:GO");
                listaJuegos.Add("Hollow Knight");

                ImprimirLista(listaJuegos);

                //Insertar
                listaJuegos.Insert(2, "Child of Light");
                Console.WriteLine();

                Insertar(listaJuegos);

                Console.WriteLine();
                ImprimirLista(listaJuegos);

                //matrices
                List<string> pelis = new List<string> { "Era de hielo", "Toy story" };
                List<int> duracion = new List<int> { 4, 3 };
                List<string> autores = new List<string> { "Nolan", "Spilberg" };

                int i = 0;

                foreach (var peliculas in pelis)
                {
                    Console.WriteLine("Nombre {0}, director: {1}, duración: {2}", peliculas, autores[i], duracion[i++]);
                }

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("Hubo un error\n", error);
            }

        }

        public static void ImprimirLista (List<string> lista)
        {
            foreach (string juego in lista) Console.WriteLine(juego);
        }

        public static void Insertar (List<string> lista)
        {
            lista.Add("Dead Space");
            ImprimirLista(lista);
        }
    }
}
