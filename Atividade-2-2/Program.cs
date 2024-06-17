using System;
namespace Atividade_2_3
{
    internal class Exercicio_2_3
    {
        public static void Main(string[] args)
        {
            double valor = 3800;
            double juros = 1.25 / 100;
            int periodo = 7;
            for(int i = 1;i <= periodo;i++)
            {
                double valorFinal = Math.Pow(1 + juros, i);
                double rendimento = valor * valorFinal;
                Console.WriteLine(rendimento);
            }
        }
    }
}