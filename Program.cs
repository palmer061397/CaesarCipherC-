using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      // Ask user for secret message to encrypt
      Console.Write("Type your secret message and press enter: ");
      // Stores user Input
      string userMessage = Console.ReadLine();
      // Convert User message into an array of chars
      char[] secretMessage = userMessage.ToCharArray();
      // Created empty array of chars to hold the encrypted messaged
      char[] encryptedMessage = new char[secretMessage.Length];
      
      // iterate through every letter in message and store it as a new letter
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char messageLetter = secretMessage[i];
        int index = Array.IndexOf(alphabet, messageLetter);
        int letterPositionPlus = (index + 3) % alphabet.Length;
        char newLetter = alphabet[letterPositionPlus];
        encryptedMessage[i] = newLetter;
      }
        // Converts encrypted character array to string
        string newMessage = String.Join("", encryptedMessage);
        Console.WriteLine(newMessage);
    }
  }
}
