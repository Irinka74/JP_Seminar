// Программа принимает кординаты двух точек х,у (х и у не равны 0) Выдает номер четверти плоскости где находится точка

Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter у: ");
int y = int.Parse(Console.ReadLine());
int result = 0;
int [,] array = new int[4, 2];

array [0, 0] = 1;
array [0, 1] = 1;

array [1, 0] = - 1;
array [1, 1] = 1;

array [2, 0] = - 1;
array [2, 1] = - 1;

array [3, 0] = 1;
array [3, 1] = - 1;

for(int i = 0; i < array.GetLength(0); i++)
{
    if((x > 0 && array[i, 0] > 0) && (y > 0 && array[i, 1] > 0))
    {
        result = i;
    }
    else if ((x < 0 && array[i, 0] < 0) && (y > 0 && array[i, 1] > 0))
    {
       result = i; 
    }
    else if ((x < 0 && array[i, 0] < 0) && (y < 0 && array[i, 1] < 0))
    {
       result = i; 
    }
    else if ((x > 0 && array[i, 0] > 0) && (y > 0 && array[i, 1] > 0))
    {
       result = i; 
    }

}
Console.WriteLine(result);
