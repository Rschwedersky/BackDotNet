Console.WriteLine("Digite o salário do funcionário: ");
var salario = Console.ReadLine();
var salarioDouble = double.Parse(salario);
var percentualAumento = 0.00;
double valorAumento = 0;
double salarioNovo = 0;

switch (salarioDouble)
{
    case <= 280:
        percentualAumento = 0.20;
        valorAumento = salarioDouble * percentualAumento;
        salarioNovo = salarioDouble + valorAumento;
        break;
    case > 280 and < 700:
        percentualAumento = 0.15;
        valorAumento = salarioDouble * percentualAumento;
        salarioNovo = salarioDouble + valorAumento;
        break;
    case > 700 and < 1500:
        percentualAumento = 0.10;
        valorAumento = salarioDouble * percentualAumento;
        salarioNovo = salarioDouble + valorAumento;
        break;
    case > 1500:
        percentualAumento = 0.05;
        valorAumento = salarioDouble * percentualAumento;
        salarioNovo = salarioDouble + valorAumento;
        break;
    default:
        break;
}

Console.Write($"Salário antes do reajuste: R$ {salarioDouble}\nPercentual de aumnento aplicado: {percentualAumento*100}%\nValor do aumento: R$ {valorAumento}\nNovo salário com aumento aplicado: R$ {salarioNovo}");
        