// See https://aka.ms/new-console-template for more information
using Financiamento_do_veículo;

Console.WriteLine("Simulador de financiamento");


Console.WriteLine("Informe o valor do veículo:");

float valor_veiculo = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o total de parcelas:");
int num_parcelas= int.Parse(Console.ReadLine());


float valor_final = 0;
if (num_parcelas == 0)
{ valor_final = Financiamento.Taxazero(valor_veiculo, num_parcelas); }

else {Console.WriteLine("Informe a taxa mensal por parcela (Em%):");
float taxa_juros = float.Parse(Console.ReadLine());
valor_final = Financiamento.TaxaFin(valor_veiculo, num_parcelas, taxa_juros); 
}
    

Console.WriteLine($"O valor total pago no veículo é: R${valor_final} ");
