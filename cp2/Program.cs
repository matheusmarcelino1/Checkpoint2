using cp2.Models;
using cp2.Utils;
using System.Globalization;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 3)
        {
            Menu.ExibirMenu();
            opcao = int.Parse(Console.ReadLine()!);

            if (opcao == 1)
            {
                Console.Write("Informe o valor: ");
                decimal valor = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                Console.Write("Informe o número do cartão: ");
                string numero = Console.ReadLine()!;

                var pagamento = new PagamentoCartao
                {
                    Valor = valor,
                    NumeroCartao = numero
                };

                Console.WriteLine(pagamento.ProcessarPagamento());
            }
            else if (opcao == 2)
            {
                Console.Write("Informe o valor: ");
                decimal valor = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                Console.Write("Informe o código de barras: ");
                string codigo = Console.ReadLine()!;

                var pagamento = new PagamentoBoleto
                {
                    Valor = valor,
                    CodigoBarras = codigo
                };

                Console.WriteLine(pagamento.ProcessarPagamento());
            }
            else if (opcao != 3)
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Encerrando sistema...");
    }
}