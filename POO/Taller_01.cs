using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nProceso;

            Console.WriteLine("Escoja uno de los siguientes procesos (1-18) escriba el número\n");
            Console.WriteLine("1| Se hace la suma desde 1 hasta n");
            Console.WriteLine("2| Se hace la suma desde 1 hasta n, pero solo los múltiplos de 3");
            Console.WriteLine("3| Tablas de multiplicar de un numero n");
            Console.WriteLine("4| Hallar los próximos 20 años bisiestos");
            Console.WriteLine("5| Calcular el mayor número de una lista de números");
            Console.WriteLine("6| Calcular el mayor y menor número de una lista de números");
            Console.WriteLine("7| Calcular suma de 1 a n, o el producto de 1 a n");
            Console.WriteLine("8| Calcular promedio notas");
            Console.WriteLine("9| Calcular n^n");
            Console.WriteLine("10| Calcular descuento de una compra");
            Console.WriteLine("11| Calcular el salario de 20 personas");
            Console.WriteLine("12| Mostrar numeros menores o iguales a 25");
            Console.WriteLine("13| Sumar números múltiplos de 3 de una lista");
            Console.WriteLine("14| Calcular las primeras 30 potencias de 3 y su suma");
            Console.WriteLine("15| Se calcula el salario según horas de una cantidad de trabajadores");
            Console.WriteLine("16| Traducir texto a código morse");
            Console.WriteLine("17| Juego de adivinanzas");
            Console.WriteLine("18| Calcular la luz encendida");

            Console.WriteLine("\n");

            while (true)
            {
                try
                {
                    nProceso = int.Parse(Console.ReadLine());
                    if (nProceso >= 1 || nProceso <= 18) break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("No dió un valor válido\n");
                    Console.WriteLine("Escoja un número del 1 al 18");
                }
            }

            switch (nProceso)
            {
                case 1:
                    SumaNumeros();
                    break;
                case 2:
                    SumaNumeros3();
                    break;
                case 3:
                    TablaMultiplicar();
                    break;
                case 4:
                    AñosBisiestos();
                    break;
                case 5:
                    MayorNumeroLista();
                    break;
                case 6:
                    MayorMenorListaNumeros();
                    break;
                case 7:
                    SumaOProducto();
                    break;
                case 8:
                    PromedioNotas();
                    break;
                case 9:
                    ElevarN();
                    break;
                case 10:
                    Descuento();
                    break;
                case 11:
                    Salario20Personas();
                    break;
                case 12:
                    MostrarNumerosLista();
                    break;
                case 13:
                    SumaNumeros3Lista();
                    break;
                case 14:
                    PotenciasSuma3();
                    break;
                case 15:
                    SalarioPersonas();
                    break;
                case 16:
                    MorseCode();
                    break;
                case 17:
                    Adivinanzas();
                    break;
                case 18:
                    LuzEncendida();
                    break;
                default:
                    Console.WriteLine("No se dió un valor válido");
                    break;
            }
            Console.ReadKey();
        }

        private static void SumaNumeros()
        {
            //Comprobar que es un número
            int numero = RetornarNumeroEntero();

            if (numero > 0) Console.WriteLine((numero * (++numero)) / 2);
            else Console.WriteLine(-(numero * (--numero)) / 2);
        }

        private static void SumaNumeros3()
        {
            //Comprobar que es un número
            int numero = RetornarNumeroEntero();
            int sum = 0;

            if (numero > 1)
            {
                for (int i = 3; i <= numero; i += 3) sum += i;
            }
            else
            {
                for (int i = -3; i >= numero; i -= 3) sum += i;
            }
            Console.WriteLine(sum);
        }

        private static void TablaMultiplicar()
        {
            //Comprobar que es un número
            int numero = RetornarNumeroEntero();

            for (int i = 0; i <= 12; i++) Console.WriteLine(numero * i);
        }

        private static void AñosBisiestos()
        {
            DateTime dec31 = new DateTime(2019, 12, 31);
            int contadorAñosBisiesto = 0;
            int contadorAños = 0;

            while (true)
            {
                DateTime dateToDisplay = dec31.AddYears(contadorAños);
                if (dateToDisplay.DayOfYear == 366)
                {
                    contadorAñosBisiesto++;
                    Console.WriteLine(dateToDisplay.Year);
                }
                contadorAños++;
                if (contadorAñosBisiesto == 20) break;
            }
        }

        private static void MayorNumeroLista()
        {
            //Meter números lista
            float[] listaNumeros = MeterNumerosLista(0, false);

            //Hallar el mayor
            float mayor = 0;

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] > mayor) mayor = listaNumeros[i];
            }
            Console.WriteLine("El número mayor es: " + mayor.ToString());
        }

        private static void MayorMenorListaNumeros()
        {
            //Añadir números alatorios a la lista
            int[] listaNumeros = AñadirNumerosListaRand(-1000, 1000, 100);

            //Hallar el mayor y menor
            int mayor = 0;
            int menor = listaNumeros[0];

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (mayor < listaNumeros[i]) mayor = listaNumeros[i];
                if (menor > listaNumeros[i]) menor = listaNumeros[i];
            }
            Console.WriteLine("El mayor es: {0}, el menor es: {1}", mayor, menor);
        }

        private static void SumaOProducto()
        {
            while (true)
            {
                Console.WriteLine("Digite 'S' para la suma, o 'P' para el producto");
                if (Console.ReadLine().ToUpper() == "S")
                {
                    SumaNumeros();
                    break;
                }
                else if (Console.ReadLine().ToUpper() == "P")
                {
                    ProductoSumaNumeros();
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida\n");
                }
            }

        }

        private static void ProductoSumaNumeros()
        {
            //Comprobar que es un número
            int numero = RetornarNumeroEntero();
            int producto = 1;

            if (numero > 1)
            {
                for (int i = 1; i <= numero; i++) producto *= i;
            }
            else
            {
                for (int i = -1; i >= numero; i--) producto *= i;
            }
            Console.WriteLine(producto);
        }

        private static void PromedioNotas()
        {
            //Validar que entre una cantidad válida
            int cantidad = 0;

            while (true)
            {
                Console.WriteLine("Digite la cantidad de notas que va a ingresar");
                cantidad = RetornarNumeroEntero();
                if (cantidad <= 0) Console.WriteLine("Entrada no válida");
                else break;
            }

            //Guardar las notas en un array
            float[] listaNumeros = MeterNumerosLista(0, true);
            int cantMenores3 = 0;
            float sumaParcialMenores3 = 0;
            float sumaParcialMayores3 = 0;

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] < 3)
                {
                    cantMenores3++;
                    sumaParcialMenores3 += listaNumeros[i];
                }
                else
                {
                    sumaParcialMayores3 += listaNumeros[i];
                }
            }

            Console.WriteLine("Promedio notas reprobadas: ", (sumaParcialMenores3 / cantMenores3));
            Console.WriteLine("Promedio notas aprobadas: ", ((sumaParcialMayores3) / listaNumeros.Length - cantMenores3));
        }

        private static void ElevarN()
        {
            //Validar que sea un número
            float numero = RetornarNumeroFloat();
            float sumaParcial = 0;

            if (numero >= 0) for (int i = 1; i < numero; i++) sumaParcial += i ^ i;
            else for (int i = -1; i > numero; i--) sumaParcial += i ^ i;

            Console.WriteLine("La suma desde +-1^+-1 hasta n^n es: ", sumaParcial.ToString());
        }

        private static void Descuento()
        {
            float valor;

            while (true)
            {
                Console.WriteLine("Ingrese el monto del producto");
                valor = RetornarNumeroFloat();
                if (valor >= 0) break;
            }
            if (valor > 100f) Console.WriteLine("Descuento del 10%: ", valor * 0.1f);
            if (valor <= 50f) Console.WriteLine("No hay descuento");
        }

        private static void Salario20Personas()
        {
            int totalHoras = 0;
            float valorHoras = 0f;

            while (true)
            {
                Console.WriteLine("Cuántas horas trabajaron en total las 20 personas");
                //Se valida que se ingrese un entero
                totalHoras = RetornarNumeroEntero();

                if (totalHoras <= 0)
                {
                    Console.WriteLine("Deben de trabajar más de 0 horas");
                    continue;
                }
                Console.WriteLine("Valor horas");
                //Se valida que se ingrese un float
                valorHoras = RetornarNumeroFloat();
                if (totalHoras <= 0)
                {
                    Console.WriteLine("Debe de valer mas de $0");
                    continue;
                }
                else break;
            }
            Console.WriteLine("Salario individual: {0}", totalHoras / 20 * valorHoras);
        }

        private static void MostrarNumerosLista()
        {
            //Ingresar números en la lista
            float[] listaNumeros = MeterNumerosLista(25, false);
            for (int i = 0; i < listaNumeros.Length; i++) if (listaNumeros[i] <= 25) Console.WriteLine(listaNumeros[i]);
        }

        private static void SumaNumeros3Lista()
        {
            //Añadir números aleatorios a la lista
            int[] listaNumeros = AñadirNumerosListaRand(-100, 100, 100);
            int sumaParcial = 0;

            for (int i = 0; i < listaNumeros.Length; i++) if (listaNumeros[i] % 3 == 0) sumaParcial += listaNumeros[i];

            Console.WriteLine("La suma de los múltiplos de 3 de la lista es: ", sumaParcial);
        }

        private static void PotenciasSuma3()
        {
            int sumaParcial = 0;
            for (int i = 1; i <= 30; i++)
            {
                sumaParcial += 3 ^ i;
                Console.WriteLine(3 ^ i);
            }
            Console.WriteLine(sumaParcial); 
        }

        private static void SalarioPersonas()
        {
            int cantPersonas = 0;
            float valorHoras = 0f;

            //Ingresar la cantidad de personas que se les va a calcular el salario
            while (true)
            {
                Console.WriteLine("Cuántas personas va a ingresar");
                cantPersonas = RetornarNumeroEntero();

                Console.WriteLine("Valor de las horas");
                valorHoras = RetornarNumeroFloat();

                if (cantPersonas <= 0 || valorHoras <= 0f)
                {
                    Console.WriteLine("Debe ingresar una cantidad mayor a 0");
                    continue;
                }
                else break;
            }

            //Guardar los nombres y las horas
            Dictionary<string, int> personasHoras = new Dictionary<string, int>();


            for (int i = 0; i < cantPersonas; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona {0}°", i);
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese las horas trabajadas de {0}", nombre);
                int horas = RetornarNumeroEntero();

                if (horas <= 0)
                {
                    Console.WriteLine("Debe ingresar una cantidad mayor a 0");
                    i--;
                    continue;
                }

                personasHoras.Add(nombre, horas);
            }

            //Imprimir los nombres, las horas y el salario
            foreach (var persona in personasHoras)
            {
                if (persona.Value < 40) Console.WriteLine("{0} trabajó {1} horas, su salario es: {3}",
                    persona.Key, persona.Value, persona.Value * valorHoras);
                else if (persona.Value >= 40) Console.WriteLine("{0} trabajó {1} horas, su salario es: {3}",
                    persona.Key, persona.Value, (40 * valorHoras) + (persona.Value - 40) * valorHoras * 2.5);
                else Console.WriteLine("{0} está en proceso de observación", persona.Key);
            }
        }

        private static void MorseCode()
        {
            /*//Inicializar un array con el alpabeto
            char[] alphabet = new char[] { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //Probar que todos los carácteres estén en el alfabeto
            while (true)
            {
                Console.WriteLine("Ingresa un mensaje a ser traducido");
                char[] mensaje = Console.ReadLine().ToUpper().ToCharArray();
                
                int contadorCiclos = 0;

                foreach (char mensajeChar in mensaje)
                {
                    int contadorMalas = 0;
                    bool charMalo = false;

                    foreach (char alphabetChar in alphabet)
                    {
                        if (mensajeChar != alphabetChar) contadorMalas++;
                        else
                        {
                            contadorMalas = 0;
                            break;
                        }
                        if (contadorMalas >= alphabet.Length)
                        {
                            Console.WriteLine("Ingresa un mensaje válido");
                            charMalo = true;
                            break;
                        }
                    }
                    if (charMalo) break;
                    contadorCiclos++;
                }
                if (contadorCiclos >= mensaje.Length) break;
            }
            Console.WriteLine("Mensaje Correcto");*/

            //-------------------------------------------------------------------------

            //Hacer el código pero con diccionario
            Dictionary<char, string> alphabet = new Dictionary<char, string>() { { ' ', "/" }, { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." }, { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" }, { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" }, { 'Y', "-.--" }, { 'Z', "--.." }, { '0', "-----" }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" }, { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." }, { '.', ".-.-.-" }, { ',', "--..--" }, { '?', "..--.." }, { '!', "-.-.--" }, { '@', ".--.-." } };

            //Probar que todos los carácteres estén en el alfabeto

            Console.WriteLine("Ingresa un mensaje a ser traducido");
            char[] mensaje = Console.ReadLine().ToUpper().ToCharArray();

            while (true)
            {
                bool charMalo = false;

                foreach (char mensajeChar in mensaje)
                {
                    if (!alphabet.ContainsKey(mensajeChar))
                    {
                        Console.WriteLine("Ingresa un mensaje válido");
                        charMalo = true;
                        break;
                    }
                }
                if (!charMalo) break;

                Console.WriteLine("Ingresa un mensaje a ser traducido");
                mensaje = Console.ReadLine().ToUpper().ToCharArray();
            }
            Console.WriteLine("Mensaje Correcto");

            //Cambiar los carácters por los del código morse
            string mensajeTraducido = "";
            foreach (char mensajeChar in mensaje) mensajeTraducido += alphabet[mensajeChar] + " ";

            //Retornar mensaje traducido
            Console.WriteLine(mensajeTraducido);
        }

        private static void Adivinanzas()
        {
            //Inicializar un número aleatorio
            int numeroSecreto = new Random().Next(0, 11);

            Console.WriteLine("El número secreto está entre 0, y 10 (cerrado)");

            int intentos = 1;

            while (true)
            {
                Console.WriteLine("Ingrese un número entero para advinar");
                int adivinar = RetornarNumeroEntero();
                if (adivinar < 0 || adivinar > 10)
                {
                    Console.WriteLine("Fuera de los límites");
                    continue;
                }
                else if (adivinar < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor a {0}", adivinar);
                    intentos++;
                }
                else if (adivinar > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es menor a {0}", adivinar);
                    intentos++;
                }
                else break;
            }

            Console.WriteLine("Felicidades el numero secreto era {0}", numeroSecreto);
            Console.WriteLine("Intentos necesarios: {0}", intentos);
        }

        private static void LuzEncendida()
        {
            Console.WriteLine("Ingrese la cantidad de personas que ingresaron a la habitación");
            int cantPersonas = RetornarNumeroEntero();

            int minEntrada = 0;
            int maxSalida = 0;

            for (int i = 1; i <= cantPersonas; i++)
            {
                Console.WriteLine("Ingrese el minuto de entrada de la persona {0}°", i);
                int entrada = RetornarNumeroEntero();

                Console.WriteLine("Ingrese el minuto de salida de la persona {0}", i);
                int salida = RetornarNumeroEntero();

                if (entrada < 0 || salida <= 0 || entrada > salida)
                {
                    Console.WriteLine("Debe ingresar una cantidad válida");
                    i--;
                    continue;
                }
                if (salida > maxSalida) maxSalida = salida;
                if (entrada < minEntrada) minEntrada = entrada;
            }
            Console.WriteLine("La luz estuvo encentida {0} minutos", maxSalida - minEntrada);
        }

        //-------------------------------Métodos auxiliares--------------------------------------

        //Añadir números a la lista
        private static int[] AñadirNumerosListaRand(int inicio, int final, int tamaño)
        {
            Random rand = new Random();
            int[] listaNumeros = new int[tamaño];

            for (int i = 0; i < listaNumeros.Length; i++) listaNumeros[i] = rand.Next(inicio, final++);

            return listaNumeros;
        }

        //Fundion para meter numeros en una lista
        private static float[] MeterNumerosLista(int limite, bool entreCeroCinco)
        {
            float[] listaNumeros;

            //Crear un array de tamaño establecido
            if (limite != 0)
            {
                listaNumeros = new float[limite];
            }
            //Crear array con un tamaño ingresado
            else
            {
                Console.WriteLine("Cuántos numero va a meter en la lista?");
                listaNumeros = new float[RetornarNumeroEntero()]; //Comprobar que es un número
            }

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                try
                {
                    Console.WriteLine("Digite el {0}°", i++);
                    listaNumeros[i] = float.Parse(Console.ReadLine());
                    if (entreCeroCinco)
                    {
                        if (listaNumeros[i] < 0 || listaNumeros[i] > 5)
                        {
                            Console.WriteLine("Debe diditar numeros mayores o iguales a cero y menores o iguales a cinco");
                            i--;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe dijitar un numero");
                    i--;
                }
            }
            return listaNumeros;
        }

        //Función para saber si lo que se ingresa es un número, si es así retornarlo
        private static int RetornarNumeroEntero ()
        {
            int numero;

            while (true)
            {
                try
                {
                    Console.WriteLine("Dijite un número");
                    numero = int.Parse(Console.ReadLine());
                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("No dió un valor válido\n");
                }
            }
        }

        private static float RetornarNumeroFloat()
        {
            float numero;

            while (true)
            {
                try
                {
                    Console.WriteLine("Dijite un número");
                    numero = float.Parse(Console.ReadLine());
                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("No dió un valor válido\n");
                }
            }
        }
    }
}
