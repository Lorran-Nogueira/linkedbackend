using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);           
        int h = int.Parse(input[1]); 

        input = Console.ReadLine().Split();
        int[] alturasMinimas = Array.ConvertAll(input, int.Parse); 

        int quantidadeBrinquedos = alturasMinimas.Count(alturaMinima => h >= alturaMinima);

        Console.WriteLine("A quantidade de brinquedos é: " + quantidadeBrinquedos);
    }
}
