// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindElementPosition(int[,] array, int m, int n)
{
    Console.Write("Введите строку в которой находится элемент: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец в которой находится элемент: ");
    int y = Convert.ToInt32(Console.ReadLine());
    int position = 0;
    try
    {
        // Программа для обычного пользователя, который считает с 1, а не с 0
        position = array[x - 1, y - 1];
        Console.Write($"Ваше число: {position}");
    }
    catch
    {
        Console.Write($"Такого элемента нет ");
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
FindElementPosition(mas, m, n);
