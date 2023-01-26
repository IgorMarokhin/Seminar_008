// Задача 53. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] arr = GetArray(rows, columns, 0, 10);

PrintArray(arr);

for (int i = 0; i < arr.GetLength(1); i++)
{
    int temp = 0;
    temp = arr[0, i];
    arr[0, i] = arr[arr.GetLength(0) - 1, i];
    arr[arr.GetLength(0) - 1, i]= temp;
}
Console.WriteLine();
PrintArray (arr);

//////////////////////////////////////////

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

void PrintArray (int [,] arr)
{
    for (int i = 0; i <arr.GetLength (0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            Console.Write ($"{arr[i, j]} ");
        }
        Console.WriteLine ();
    }
}