using System;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("0) Sair");
            Console.WriteLine("1) Tabuada de cada número");
            Console.WriteLine("2) Adivinhar número");

            Console.Write("Opção: ");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 0:
                        sair = true;
                        break;
                    case 1:
                        Tabuada();
                        break;
                    case 2:
                        Adivinhacao();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            }
        }
    }

    static void Tabuada()
    {
        Console.Write("Digite um número para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int[] tabuada = TabuadaResolver.GerarTabuada(numero);

        Console.WriteLine($"Tabuada do {numero}:");
        TabuadaResolver.ImprimirTabuada(tabuada);
    }

    static void Adivinhacao()
    {
        Console.WriteLine("Vou pensar em um número entre 1 e 100. Tente adivinhar!");
        
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            int palpite;

            if (int.TryParse(entrada, out palpite))
            {
                tentativas++;
                if (palpite == numeroSecreto)
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Muito alto. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
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
