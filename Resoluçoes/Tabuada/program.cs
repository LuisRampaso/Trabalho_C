using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int[] tabuada = TabuadaResolver.GerarTabuada(numero);

        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabuada[i]}");
        }
    }
}

public class TabuadaResolver
{
    public static int[] GerarTabuada(int numero)
    {
        int[] tabuada = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabuada[i] = numero * (i + 1);
        }
        return tabuada;
    }
}