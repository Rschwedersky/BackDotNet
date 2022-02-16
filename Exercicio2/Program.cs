Console.Write("Digite a temperatura em Celsius: ");
double C = Convert.ToDouble(Console.ReadLine());
double Fahrenheit = (C * 9) / 5 + 32;
Console.WriteLine("Temperatura em Fahrenheit: " + Fahrenheit);
Console.ReadKey();