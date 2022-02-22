

//var listaNomes = new List<string>();
//listaNomes = new List<string>
//{
//    "rodrigo",
//    "bruna"
//};

//listaNomes.Add("eduardo");

//for (int i = 0; i < listaNomes.Count; i++)
//{
//    if(listaNomes[i].Length == 5)
//       Console.WriteLine(listaNomes[i]);
//}
//Console.ReadKey();

//var nomeComLetras = listaNomes.Where(x => x.Length == 5).ToList();
//Console.WriteLine("{0}", String.Join(",", nomeComLetras));

//String[] meuArray = new String[] { "doda", "ajdjewj" };
int[] array = { 2, 4, 6, 8, 2, 2, 4, 5, 6, 3 };
Array.Reverse(array);

Console.WriteLine(String.Join(',', array));


var listanumeros = new List<int>
{ 1,2,3,4,5,6,87,3,6,8};

listanumeros.Reverse();
Console.WriteLine(String.Join(',', listanumeros));


var listanotas1 = new List<int>
{ 1,2,3,4};

var listanotas2 = new List<int>
{ 1,2,3,4};

var listanotas3= new List<int>
{ 1,2,3,4};

var media1 = listanotas3.Sum()/ listanotas3.Count();
