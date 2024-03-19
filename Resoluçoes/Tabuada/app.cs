using System;

public class Tabuada
{
    public int Numero { get; }

    public Tabuada(int numero)
    {
        Numero = numero;
    }

    public int[] GerarTabuada()
    {
        int[] tabuada = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabuada[i] = Numero * (i + 1);
        }
        return tabuada;
    }
}