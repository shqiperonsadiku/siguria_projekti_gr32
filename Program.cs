using System;
using System.Linq;

namespace siguriaProjektiConsole
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string inputText = Console.ReadLine();
            inputText = inputText.ToUpper();
            // Injorimi i shenjave te pikesimit dhe hapesirave ne tekst
            inputText = inputText.Replace('.'.ToString(), string.Empty);
            inputText = inputText.Replace(','.ToString(), string.Empty);
            inputText = inputText.Replace('-'.ToString(), string.Empty);
            inputText = inputText.Replace('!'.ToString(), string.Empty);
            inputText = inputText.Replace('?'.ToString(), string.Empty);
            inputText = inputText.Replace('\''.ToString(), string.Empty);
            inputText = inputText.Replace(')'.ToString(), string.Empty);
            inputText = inputText.Replace('('.ToString(), string.Empty);
            inputText = inputText.Replace(':'.ToString(), string.Empty);
            inputText = inputText.Replace(';'.ToString(), string.Empty);
            inputText = inputText.Replace(' '.ToString(), string.Empty);
            Console.WriteLine("\n");
            Console.WriteLine("Letters Frequency:");

            while (inputText.Length > 0)
            {
                int countOfChar = 0;
                Console.Write($"{inputText[0]}= ");
                for(int i=0; i<inputText.Length; i++)
                {
                    if(inputText[0] == inputText[i])
                    {
                        countOfChar++;
                    }
                }
                Console.WriteLine($"{countOfChar}");
                inputText = inputText.Replace(inputText[0].ToString(), string.Empty);
            }

            Console.Write("\nEnter a key value: ");
            string keyValue = Console.ReadLine();

            string decryptedText = Decrypt(inputText, int.Parse(keyValue));
            Console.WriteLine("Decrypted Text: " + decryptedText);
            
        }

        static char Encrypt(char ch, int key)
        {
            if (!char.IsLetter(ch)) return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((ch + key - offset) % 26 + offset); //llogaritja e zhvendosjes se shkronjave
        }

        static string Encrypt(string plaintext, int key)
        {
            //kthimi i tekstit te enkriptuar duke e perdorur funksionin Encrypt per karaktere dhe
            //duke e kthy ate si array(apo tekst te plote)      
            return new string(plaintext.Select(ch => Encrypt(ch, key)).ToArray()); 
        }

        static string Decrypt(string ciphertext, int key)
        {
            //Dekriptimi i tekstit
            return Encrypt(ciphertext, 26 - key);
        }
    }
}
