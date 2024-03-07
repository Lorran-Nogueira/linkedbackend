using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva a Quantidade de competidores");
        int casosTeste = int.Parse(Console.ReadLine());

        for (int i = 0; i < casosTeste; i++)
        {
            Console.WriteLine("Escreva o Grid de Largada dos competidores");
            int[] largada = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => int.Parse(c.ToString()));


            Console.WriteLine("Escreva o Grid de Chegada dos competidores");
            int[] chegada = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => int.Parse(c.ToString()));

            int ultrapassagens = CalcularUltrapassagens(largada, chegada);

            Console.WriteLine($"No total foram: {ultrapassagens} ultrapassagens");
        }
    }

    static int CalcularUltrapassagens(int[] largada, int[] chegada)
    {
        int ultrapassagens = 0;

        for (int i = 0; i < chegada.Length; i++)
        {
            int posicaoLargada = Array.IndexOf(largada, chegada[i]);

            largada[posicaoLargada] = -1;

 
            ultrapassagens += Math.Max(0, posicaoLargada - i);
        }

        return ultrapassagens;
    }
}
