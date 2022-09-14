// Задача HARD SORT.
// Задайте двумерный массив из целых чисел.
// Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 100);
    }
    return array;

}
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

int [,] SortArray(int[,] array, int m, int n)
{
    int x = m * n;
    int[] temparray = new int[x];
    int k = 0;
    if (k < x)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                temparray[k] = array[i, j];
                k++;
            }
        }
    }
    // Console.WriteLine(string.Join(", ", temparray));

    for (int i = 0; i < temparray.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < temparray.Length; j++)
        {
            if (temparray[j] < temparray[min]) min = j;
        }

        int temp = temparray[i];
        temparray[i] = temparray[min];
        temparray[min] = temp;
        // Console.Write($"{temparray[i]}, ");
    }
    Console.WriteLine("Сортированный массив");
    int[,] sortedarray = new int[m, n];
    for (int l = 0; l < temparray.Length; l++)
    {
        for (int i = 0; i < sortedarray.GetLength(0); i++)
        {
            for (int j = 0; j < sortedarray.GetLength(1); j++)
            {
                sortedarray[i, j] = temparray[l];
                l++;
                Console.Write(sortedarray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    return sortedarray;
}


Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов  двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
SortArray(mas, m, n);