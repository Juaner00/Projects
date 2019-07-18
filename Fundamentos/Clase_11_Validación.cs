using System;

class MainClass 
{
  public static void Main () 
  {
    Random nRand = new Random();
    int contador = 0, resp = 0, suma = 1;

    while (resp != suma && contador != 3){

      int a = nRand.Next(1, 10);
      int b = nRand.Next(1, 10);
      suma = a + b;

      Console.WriteLine("Cuál es la suma de los siguientes numeros?\nIntentos: " + (3-contador));
      Console.WriteLine(a + " + " + b);
      resp = int.Parse(Console.ReadLine());

      contador++;

    }

    if (resp == suma) Console.WriteLine("Respuesta correcta\nInicio de programa");
    else Console.WriteLine("Intendos acabados\nAcceso denegado");
  }
}
