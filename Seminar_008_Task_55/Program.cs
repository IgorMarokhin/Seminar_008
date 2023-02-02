//Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.  
//В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
 
Console.Clear();

Console.Write("Введите количество строк массива: "); 
int rows = int.Parse(Console.ReadLine() ?? ""); 
Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine() ?? ""); 

int[,] arr = GetArray(rows, columns, 0, 10); 
PrintArray(arr);
Console.WriteLine();

int[,] matrix = transposition(arr);
Console.WriteLine();
PrintArray (matrix);

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

int[,] transposition(int[,] matrix) 
{ 
    int[,] res = new int[matrix.GetLength(1),matrix.GetLength(0)]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            res[j,i] = matrix[i,j]; 
        }        
    } 
    return res; 
}