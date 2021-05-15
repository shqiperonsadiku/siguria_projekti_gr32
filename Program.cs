using System;

namespace siguriaProjektiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string inputText = Console.ReadLine();
            inputText = inputText.ToUpper();
            inputText = inputText.Replace('.'.ToString(), string.Empty);
            inputText = inputText.Replace(','.ToString(), string.Empty);
            inputText = inputText.Replace('-'.ToString(), string.Empty);
            inputText = inputText.Replace('!'.ToString(), string.Empty);
            inputText = inputText.Replace('?'.ToString(), string.Empty);
            inputText = inputText.Replace('\''.ToString(), string.Empty);
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
        }
    }
}
