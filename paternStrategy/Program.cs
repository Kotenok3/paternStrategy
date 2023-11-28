using System.Threading.Channels;
using paternStrategy;

var sort = new SortedArray(new BabbleSort());

var array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    array[i] = array.Length - i;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Сортируем стратегией переданной в кострукторе");

sort.Sort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine();



for (int i = 0; i < array.Length; i++)
{
    array[i] = array.Length - i;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Сортируем другой стратегией");

sort.SetStrategy(new MergeSort());
sort.Sort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
