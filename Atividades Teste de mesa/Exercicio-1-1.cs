using System;
namespace Atividades_Teste_de_mesa
{
    internal class Atividade_1_1
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = ((a + b) / 2);
            int cont = 0;
            int[] vetor = new int[4];
            c = c - 40;

            for (int i = 0; i < 4; i++)
            {
                vetor[i] = 0;
            }
            while (cont <= 3)
            {
                if (cont == 3)
                {
                    vetor[3] = a + b + c;
                    Console.WriteLine(vetor[3]);
                }
                else
                {
                    Console.WriteLine("NaN");
                }
                cont++;
            }
        }
    }
}
