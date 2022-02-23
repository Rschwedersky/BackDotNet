Console.Write("Digite um numero para reverter a ordem: ");
int numero = Convert.ToInt32(Console.ReadLine());
int reverser = int.Parse(numero.ToString().Reverse().Aggregate("", (s, c) => s + c));
Console.WriteLine(reverser);