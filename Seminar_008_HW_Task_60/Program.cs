// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.

Console.Clear();

Console.Write("Введите X: "); 
int X = int.Parse(Console.ReadLine() ?? ""); 
Console.Write("Введите Y: "); 
int Y = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Z: "); 
int Z = int.Parse(Console.ReadLine() ?? "");

int[,,] arr3D = GetArray(X, Y, Z, 0, 10);

CreateArray(arr3D);
PrintArray(arr3D);

/////////////////////////////////////////

int[,,] GetArray(int X, int Y, int Z, int minValue, int maxValue) 
{ 
    int[,,] result = new int[X, Y, Z]; 
    for (int i = 0; i < X; i++) 
    { 
        for (int j = 0; j < Y; j++) 
        { 
            for (int k = 0; k < Z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result; 
}

void PrintArray (int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={arr3D[i,j,k]}; ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

void CreateArray(int[,,] arr3D)
{
    int[] temp = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
            number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < arr3D.GetLength(0); x++)
    {
        for (int y = 0; y < arr3D.GetLength(1); y++)
        {
            for (int z = 0; z < arr3D.GetLength(2); z++)
            {
                arr3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}