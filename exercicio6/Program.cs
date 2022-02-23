
Console.Write("Digite l1: ");
int l1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite l2: ");
int l2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite l3: ");
int l3 = Convert.ToInt32(Console.ReadLine());

if((l1+l2)>l3| (l3 + l2) > l1 | (l3 + l1) > l2)
{
    Console.WriteLine("É triangulo");
    if (l1 == l2 & l2 == l3) { Console.WriteLine("É Triangulo Equilátero"); };
    if((l1 == l2) | (l1 == l3)| (l2 == l3)) { Console.WriteLine("É Triangulo Isósceles"); }
    else { Console.WriteLine("É Triangulo Escaleno"); }
}
else { Console.WriteLine("Nao e triangulo"); }


Console.ReadKey();