using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de Frase que você gostaria de saber as vogais e consoantes");
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            Console.WriteLine("Digite Uma frase");
            string text = Console.ReadLine();
            int vowels = 0, consonants = 0;

            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine($"Nessa Frase temos {vowels} vogais e {consonants} consoantes");
        }
    }
}
