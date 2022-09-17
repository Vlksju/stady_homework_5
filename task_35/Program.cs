Console.WriteLine("Программа, которая ищет количество элементов случайнозаполненного массива из 123 чисел, лежащих в отрезке [10,99]");

int[] arr = new int[123];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-123, 124);
}

Console.Write("Исходный массив = [");
Console.Write(string.Join("] [", arr));
Console.WriteLine("]");

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i]>=10) & (arr[i]<=99)) { sum++; }
}

Console.WriteLine($"Количество элементов = {sum}"); 