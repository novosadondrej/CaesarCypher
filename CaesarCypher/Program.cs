using System;

namespace CaesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[]
            {
             'a','á','b','c','č','d','e','ě','é','f','g','h','i','í','j','k','l','m','n','o',
             'p','q','r','ř','s','š','t','u','v','w','x','y','z','ž'
            };

            Console.Write("Zadejte co chcete zašifrovat: ");
            string text = Console.ReadLine();
            text.ToLower();
            Console.Write("Zadejte číselný klíč od 0 do 25: ");
            int key = Convert.ToInt32(Console.ReadLine());
           

            char[] secretMess = text.ToCharArray();
            char[] enryptedMess = new char[secretMess.Length];
            for (int i = 0; i < secretMess.Length; i++)
            {
                char letter = secretMess[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int newPosition = (letterPosition + key) % 26;
                char letterEncoded = alphabet[newPosition];
                enryptedMess[i] = letterEncoded;
            }

            string encodedString = String.Join("", enryptedMess);
            Console.WriteLine($"Zpráva je: " + encodedString);

            Console.WriteLine("Pro odšifrování zmmáčkněte Enter");
            Console.ReadLine();

            char[] decrypt = encodedString.ToCharArray();
            char[] decryptedMess = new char[decrypt.Length];
            for (int i = 0; i < decrypt.Length; i++)
            {
                char pismeno= decrypt[i];
                int letterPosition = Array.IndexOf(alphabet, pismeno);
                int newPosition = (letterPosition - key) % 26;
                char letterEncoded = alphabet[newPosition];
                decryptedMess[i] = letterEncoded;
            }
            string decodedString = String.Join("", decryptedMess);
            Console.WriteLine($"Základ je: " + decodedString);
        }

    }
}

