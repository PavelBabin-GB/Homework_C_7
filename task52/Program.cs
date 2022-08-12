//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random random = new Random();
int[,] arr = new int[random.Next(1, 7), random.Next(1, 7)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ Math.Round(sum / arr.GetLength(0), 1)} ");
}
