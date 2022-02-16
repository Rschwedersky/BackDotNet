int cont = 0;
int ultimoValor = 0;

while (cont < 5)
{
    Console.WriteLine("valor");
    var valor = Console.ReadLine();
    var vInt = Convert.ToInt32(valor);
    if (vInt > ultimoValor)
    {
        ultimoValor = vInt;
    }
    cont++;
} 
Console.WriteLine("O maior valor é: "+ultimoValor);
