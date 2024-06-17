using System;
namespace Atividade_1_3
{
    internal class Exercicio_1_3
    {
        public static void Main(string[] args)
        {
            int a = 7;
            int b = a - 6;
            int[] vetor = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (b < a)
                {
                    vetor[i] = a + b;
                    Console.WriteLine(vetor[i]);
                    b = b + 2;
                }
                else
                {
                    Console.WriteLine("NaN");
                }

            }
        }
    }
}