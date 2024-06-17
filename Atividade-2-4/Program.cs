using System;
namespace Atividade_2_4
{
    internal class Exercicio_2_4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor inicial do investimento em Reais:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o juros mensal( em percentagem):");
            double juros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o periodo do investimento em meses:");
            juros = juros / 100;
            int periodo = Convert.ToInt32(Console.ReadLine());
            double rendimento;
            for(int i = 1; i <= periodo; i++)
            {
                rendimento = (valor * juros) + valor;
                Console.WriteLine($"Valor total do rendimento: {rendimento}");
                Console.WriteLine("Deseja efetuar um saque deste valor?(s/n):");
                char resposta = Convert.ToChar(Console.ReadLine());
                while ( resposta == 's' ) {
                    Console.WriteLine("Informe o valor desejado:");
                    double saque = Convert.ToDouble(Console.ReadLine());
                    rendimento = rendimento - saque;
                    Console.WriteLine($"Saque de {saque} realizado, saldo após o saque: {rendimento}");
                    resposta = 'n';
                }
                i++;
            }
        }
    }
}