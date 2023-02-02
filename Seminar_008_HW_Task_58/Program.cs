// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

Console.Clear();
int[,] arr1 = GetArray(4, 4, 0, 10);
int[,] arr2 = GetArray(4, 4, 0, 10);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
int[,] result = ProductArray(arr1, arr2);
Console.WriteLine("Результат произведения двух массивов:");
PrintArray(result);

////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductArray(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return result;
}