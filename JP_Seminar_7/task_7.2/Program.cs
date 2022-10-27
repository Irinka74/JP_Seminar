// Задайте двухмерный массив размера m на n каждый элемент массива находится по формуле
//А (m+n)
//Выведите полученный массив на экран
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i +j;
        }
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
PrintArray(GetArray(m,n));