using System;
using System.Collections.Generic;

class Translator
{
  static void Main(string[] args)
  {
    Dictionary<char, string> alphabet = new Dictionary<char, string>() { { ' ', "/" }, { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." }, { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" }, { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" }, { 'Y', "-.--" }, { 'Z', "--.." }, { '0', "-----" }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" }, { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." }, { '.', ".-.-.-" }, { ',', "--..--" }, { '?', "..--.." }, { '!', "-.-.--" }, { '@', ".--.-." } };

    Console.WriteLine("Ingresa un mensaje a ser traducido");
    char[] mensaje = Console.ReadLine().ToUpper().ToCharArray();
    
    string mensajeTraducido = "";

    foreach (char mensajeChar in mensaje) 
    {
      try 
      {
        mensajeTraducido += alphabet[mensajeChar] + " ";
      }
      catch (Exception)
      {
        Console.WriteLine(mensajeChar + " No es un carácter válido");
      }
    }

    Console.WriteLine(mensajeTraducido);
  }
}
