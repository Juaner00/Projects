using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "Hola mundo";
            String texto2 = "Hola mundo";

            DateTime hoy = DateTime.Today;
            Console.WriteLine(hoy);
            Console.WriteLine(hoy.ToString());

            if (texto1 == texto2) // es mejor utilizar texto1.Equals(texto2);
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
                Console.ReadKey();
            }
        }
    }
}
