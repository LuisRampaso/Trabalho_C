using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int[] tabuada = TabuadaResolver.GerarTabuada(numero);

        Console.WriteLine($"Tabuada do {numero}:");
        TabuadaResolver.ImprimirTabuada(tabuada);
    }
}

public static class TabuadaResolver
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

    public static void ImprimirTabuada(int[] tabuada)
    {
        for (int i = 0; i < tabuada.Length; i++)
        {
            Console.WriteLine(tabuada[i]);
        }
    }
}
