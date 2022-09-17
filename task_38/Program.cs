internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа, которая находит разницу между максимальным и минимальным элементами массива. Массив и его размерность вводятся с клавиатуры");

        Console.Write("Введите размер массива  ");
        int size = Convert.ToInt32(Console.ReadLine());

        double[] arr = new double[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите элемент массива номер  {i}  ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Исходный массив = [");
        Console.Write(string.Join("] [", arr));
        Console.WriteLine("]");

        double max = arr[1];
        double min = arr[1];

for (int i = 0; i < size; i++)
{
          if (arr[i]>max) { max=arr[i];}
    else {if (arr[i]<min) { min=arr[i];}}

}
        
        double sum = max - min;


        Console.WriteLine($"Разница элементов = {sum}");

       
    }
}