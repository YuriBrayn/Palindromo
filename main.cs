using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
            Console.WriteLine("Digite a palavra ou frase");
            var text = Console.ReadLine().Replace(" ", "");
            if (CheckPalindromo(text)) 
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            };
  }

  public static bool CheckPalindromo(string text)
  {
    return text == new string(text.Reverse().ToArray());
  }
  
}