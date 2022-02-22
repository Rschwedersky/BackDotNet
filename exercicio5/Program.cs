using System.Linq;

int cont = 0;
List<int> lista = new List<int>();

while (cont < 10)
{
    Console.WriteLine("valor");
    var valor = Console.ReadLine();
    var vInt = Convert.ToInt32(valor);
    lista.Add(vInt);
    cont++;
}
Console.WriteLine(String.Join(',', lista));
List<int> newlista = lista.OrderByDescending(x => x).ToList();
Console.WriteLine(String.Join(',', newlista));