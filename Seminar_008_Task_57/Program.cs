// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

Console.Clear();

Console.Write("Введите количество строк массива: "); 
int rows = int.Parse(Console.ReadLine() ?? ""); 
Console.Write("Введите количество столбцов массива: "); 
int columns = int.Parse(Console.ReadLine() ?? ""); 
int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    FindElements(arr, i);
}

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

void FindElements(int[,] arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                count += 1;
            }
        }
    }
    if (count > 0)
    {
        Console.WriteLine($"{number} встречается {count} раз(а)");
    } 
}