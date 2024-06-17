using System;

namespace Atividade_1_2
{
    internal class Exercicio_1_2
    {
        public static void Main(string[] args)
        {
            int a = 2;
            int[] vetor = new int[5];
            for(int i = 0; i < 5; i++)
            {
                if(a <= 6)
                {
                    vetor[i] = a*10;
                    Console.WriteLine(vetor[i]);
                    a++;
                }
            }
        }

    }
}