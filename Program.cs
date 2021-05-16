using System;
using System.Linq;

namespace siguriaProjektiConsole
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ciphertext: ");
            string inputText = Console.ReadLine();
            string inputTextUpper = inputText.ToUpper();
            // Injorimi i shenjave te pikesimit dhe hapesirave ne tekst
            inputTextUpper = inputTextUpper.Replace('.'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace(','.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace('-'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace('!'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace('?'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace('\''.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace(')'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace('('.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace(':'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace(';'.ToString(), string.Empty);
            inputTextUpper = inputTextUpper.Replace(' '.ToString(), string.Empty);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Letters Frequency in ciphertext:");

            while (inputTextUpper.Length > 0)
            {
                int countOfChar = 0;
                Console.Write($"{inputTextUpper[0]}= ");
                for(int i=0; i<inputTextUpper.Length; i++)
                {
                    if(inputTextUpper[0] == inputTextUpper[i])
                    {
                        countOfChar++;
                    }
                }
                Console.WriteLine($"{countOfChar}");
                inputTextUpper = inputTextUpper.Replace(inputTextUpper[0].ToString(), string.Empty);
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Frequency of English Alphabet letters:");
            EnglishLetterFrequency();
            Console.WriteLine("--------------------------------------------------------------");
        EnterKey:
            Console.Write("\nEnter a key value: ");            
            string keyValue = Console.ReadLine();
            string decryptedText = Decrypt(inputText, int.Parse(keyValue));
            Console.Write("--------------------------------------------------------------\n");
            Console.WriteLine("DECRYPTED TEXT:\n"+ decryptedText);
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("Press 1 to enter key value again or any other key to close the program: ");
            string repeatKey = Console.ReadLine();
            if(repeatKey == "1")
            {
                goto EnterKey;
            }       
        }

        static void EnglishLetterFrequency()
        {
            Console.WriteLine("A= "+ 8.12);           
            Console.WriteLine("B= "+ 1.49);
            Console.WriteLine("C= "+ 2.71);
            Console.WriteLine("D= "+  4.32);
            Console.WriteLine("E= "+ 12.02);
            Console.WriteLine("F= "+ 2.30);
            Console.WriteLine("G= "+ 2.03);
            Console.WriteLine("H= "+ 5.92);
            Console.WriteLine("I= "+ 7.31);
            Console.WriteLine("J= "+  0.10);
            Console.WriteLine("K= "+ 0.69);
            Console.WriteLine("L= "+ 3.98);
            Console.WriteLine("M= "+ 2.61);
            Console.WriteLine("N= "+ 6.95);
            Console.WriteLine("O= "+ 7.68);
            Console.WriteLine("P= "+ 1.82);
            Console.WriteLine("Q= "+  0.11);
            Console.WriteLine("R= "+  6.02);
            Console.WriteLine("S= "+ 6.28);
            Console.WriteLine("T= "+ 9.10);
            Console.WriteLine("U= "+ 2.88);
            Console.WriteLine("V= "+ 1.11);
            Console.WriteLine("W= "+ 2.09);
            Console.WriteLine("X= "+ 0.17);
            Console.WriteLine("Y= "+ 2.11);
            Console.WriteLine("Z= "+ 0.07);
        }
        static char EncryptChar(char ch, int key)
        {
            if (!char.IsLetter(ch)) return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((ch + key - offset) % 26 + offset); //llogaritja e zhvendosjes se shkronjave
        }

        static string Encrypt(string plaintext, int key)
        {
            //kthimi i tekstit te enkriptuar duke e perdorur funksionin Encrypt per karaktere dhe
            //duke e kthy ate si array(apo tekst te plote)      
            return new string(plaintext.Select(ch => EncryptChar(ch, key)).ToArray()); 
        }

        static string Decrypt(string ciphertext, int key)
        {
            //Dekriptimi i tekstit
            return Encrypt(ciphertext, 26 - key);
        }
    }
}
