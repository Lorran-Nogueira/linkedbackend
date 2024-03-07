using System;
using System.Linq;

class Program
{
    static void Main()
    {
   
        Console.WriteLine("Quantidade de competidores:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Número mínimo de competidores a serem classificados:");
        int k = int.Parse(Console.ReadLine());

        int[] pontuacoes = new int[n];
        Console.WriteLine("pontuações dos competidores:");
        for (int i = 0; i < n; i++)   
        {
            pontuacoes[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(pontuacoes, (a, b) => b.CompareTo(a));

        int classificados = ContarClassificados(pontuacoes, k);

        Console.WriteLine("O Numero de competidores classificados é: " + classificados);
    }

    static int ContarClassificados(int[] pontuacoes, int k)   
    {
        int pontuacaoMinima = pontuacoes[k - 1];

        int classificados = pontuacoes.Count(pontuacao => pontuacao >= pontuacaoMinima);

        return classificados;
    }
}
