// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Введите количество строк массива: "); 
int rows = int.Parse(Console.ReadLine() ?? ""); 
Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine() ?? ""); 
int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine();
SortRowsArray(arr);
PrintArray(arr);

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
    for (int i = 0; i <arr.GetLength (0); i++) 
    { 
        for (int j =0; j < arr.GetLength(1); j++) 
        { 
            Console.Write ($"{arr[i, j]} "); 
        } 
    Console.WriteLine (); 
    } 
}

void SortRowsArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int n = 0; n < arr.GetLength(1) - 1; n++)
            {
                if (arr[i, n] > arr[i, n + 1])
                {
                    int temp = arr[i, n + 1];
                    arr[i, n + 1] = arr[i, n];
                    arr[i, n] = temp;
                }
            }
        }
    }
}