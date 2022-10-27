// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

int [,] UpdateArray(int[,] array)
{
int temp = 0;

 for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[m-1, i];
        array[m-1, i] = temp;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}
int [,] array1 = GetArray(m,n);
PrintArray(array1);
System.Console.ReadLine();

PrintArray(UpdateArray(array1));
