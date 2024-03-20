// See https://aka.ms/new-console-template for more information
using Calculadesconto_return;

bool entrada = true;
do
{

    Console.WriteLine("Calculadora de Desconto");
    Console.WriteLine("Informe o valor");
    float valor_atual = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a porcentagem de desconto");
    float desconto = float.Parse(Console.ReadLine());
    Desconto_Return des = new Desconto_Return();
    Console.WriteLine($"o valor de desconto é {des.PorcentagemValor(valor_atual, desconto)}");
    Console.WriteLine($"o valor final é {des.ValorFinal(valor_atual, desconto)}");





} while (entrada);

