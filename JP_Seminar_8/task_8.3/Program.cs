//Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.



using System;

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());
int[,] Array = CreateArray(m, n);




int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 20);
        }
    }

    return array;
}


int[,] UpdateArray(int[,] array, int[] coordinates)
{
    int[,] SmallArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( i!= coordinates[0] || j!= coordinates[1])
            {
                SmallArray[i, j] = array[i, j];                                
            }                
        }
    }

    return array;
}

// Поиск мин. значения
int [] MinElement(int[,] array)
{
    int xmin = 0;
    int ymin = 0;
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min=array[i, j];
                xmin = i;
                ymin = j;
            }
        }
    }
    
return new int[] { xmin, ymin };
}


    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

