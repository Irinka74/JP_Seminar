// напишите программу замена элементов массива положительные элементы замените на соответствующие отрицательные и наоборот

int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}

/*int GetSumPositiveElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    return sum;
}*/



string GetArray(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}, ";
        
    }
    return sum;
}

string GetArray1(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]*-1}, ";

    }
    return sum;
}


int[] array = CreateArray(12, -9, 10);

System.Console.WriteLine(GetArray(array));
System.Console.WriteLine(GetArray1(array));
