using System;
namespace Exercicio_2_1
{
    internal class Atividade_2_1
    {
        public static void Main(string[] args)
        {
            double ValorPresente = 1.000;
            double TaxaJuros = 5.30 / 100;
            int periodo = 10;
            double valor = ValorPresente * (1 + TaxaJuros);
            double valorFinal = Math.Pow(valor, periodo);
            Console.WriteLine(valorFinal);
        }
    }
}