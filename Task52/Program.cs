// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

void ColumnsArithmeticalMean(int[,] array, int m, int n)
{
    double[] sum = new double[n];
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum[i] = sum[i] + array[j, i];
        }
        sum[i] = Math.Round((sum[i] / m), 2);
        Console.WriteLine($"{sum[i]}");
    }
}
Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
ColumnsArithmeticalMean(mas, m, n);
