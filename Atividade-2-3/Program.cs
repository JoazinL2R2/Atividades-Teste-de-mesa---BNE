using System;
namespace Atividade_2_3
{
    internal class Exercicio_2_3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do investimento inicial:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o juros sob o valor(em percentagem):");
            double juros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o periodo do investimento em meses:");
            juros = juros / 100;
            int periodo = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= periodo; i++) { 
                double valorFinal = Math.Pow(1 + juros,i);
                double rendimento = (valor * juros) + valor;
                Console.WriteLine($"O valor total do rendimento será: {rendimento} Reais, sendo {rendimento-valor} Reais de juros");
                i++;
            }
        }
    }
}