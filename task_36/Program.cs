Console.WriteLine("Программа, которая подсчитывает сумму элементов массива, стоящих на нечетных позициях");

int[] arr = new int[6];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(34, 736);
}

Console.Write("Исходный массив = [");
Console.Write(string.Join("] [", arr));
Console.WriteLine("]");

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i%2==1) { sum=sum+arr[i]; }
}

Console.WriteLine($"Сумма элементов = {sum}"); 