// See https://aka.ms/new-console-template for more information
double custoestimado = 0, consumoEnergia = 0, tempoUsoDiario = 0;

Console.Write("Digite consumo de energia do seu equipamento (em kWh/mês): "); 
consumoEnergia = double.Parse(Console.ReadLine());

Console.Write("Tempo de uso diário (h): ");
tempoUsoDiario = double.Parse(Console.ReadLine());

custoestimado = consumoEnergia * tempoUsoDiario *  0.62258;

Console.WriteLine($"O custo estimado de energia é: {custoestimado:C2}");