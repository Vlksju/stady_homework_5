Console.WriteLine("Программа, которая ищет количество четных элементов случайнозаполненного массива трехзначными  числами");

int[] arr = new int[7];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}

Console.Write("Исходный массив = [");
Console.Write(string.Join("] [", arr));
Console.WriteLine("]");

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2==0) { sum++; }
}

Console.WriteLine($"Количество элементов = {sum}"); 