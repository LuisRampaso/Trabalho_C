using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vou pensar em um número entre 1 e 100. Tente adivinhar!");
        Adivinhar();
    }

    static void Adivinhar()
    {
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