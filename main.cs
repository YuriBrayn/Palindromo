using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
            Console.WriteLine("Digite a palavra ou frase");
            var text = Console.ReadLine().Replace(" ", "").ToLower();
            if (CheckPalindromoWithFOR(text)) 
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            };
  }

  public static bool CheckPalindromoWithLINQ(string text)
  {
    return text == new string(text.Reverse().ToArray());
  }

   public static bool CheckPalindromoWithFOR(string text) 
   {
        for (int i = 0, j = text.Length -1; i <= j; i++,j--) {
            if (text[i] != text[j]) {
                return false;
            }
        }
        return true;
    }
  
}