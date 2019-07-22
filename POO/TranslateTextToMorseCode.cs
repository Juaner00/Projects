using System;
using System.Collections.Generic;

class Translator
{
  static void Main(string[] args)
  {
    
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
}
