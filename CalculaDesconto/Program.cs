﻿// See https://aka.ms/new-console-template for more information
using CalculaDesconto;

bool entrada = true;
do {   
    
    Console.WriteLine("Calculadora de Desconto");
    Console.WriteLine("Informe o valor");
    float valor_atual = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a porcentagem de desconto");
    float desconto = float.Parse(Console.ReadLine());
    Console.WriteLine($"o valor de desconto é {Desconto.PorcentagemValor(valor_atual, desconto)}");
    Console.WriteLine($"o valor final é {Desconto.ValorFinal(valor_atual, desconto)}");





} while (entrada);

  








