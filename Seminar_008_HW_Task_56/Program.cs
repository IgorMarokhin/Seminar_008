// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк массива: "); 
int rows = int.Parse(Console.ReadLine() ?? ""); 
Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine() ?? ""); 
int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine();
int[] sumArr = SumElementRowsArray(arr);
Console.WriteLine("Суммы элементов в строках массива равны:");
Console.WriteLine(string.Join(", ", sumArr));
int minSumRowsArray = FindRowsMinSum (sumArr) + 1;
Console.WriteLine($"Номер строки с минимальной суммой элементов: {minSumRowsArray}");

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

void PrintArray (int [,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            Console.Write ($"{arr[i, j]} "); 
        } 
    Console.WriteLine (); 
    } 
}

int[] SumElementRowsArray(int [,] arr)
{
    int[] sumArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++) 
        { 
            sumArray[i] = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sumArray[i] += arr[i, j];
            }
        }
        return sumArray;
}

int FindRowsMinSum(int[] array)
{
    int minRowInd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[minRowInd])
        {
            minRowInd = i;
        }
    }
    return minRowInd;
}