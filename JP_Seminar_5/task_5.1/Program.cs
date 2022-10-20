// задайте массив из 12 элементов заполненый случайными числами из промежутка (-9,9)
//найдите сумму отрицательных и положительных элементов массива

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

int GetSumPositiveElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int GetSumNegativeElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum = sum + array[i];
    }
    return sum;
}

string GetArray(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{ array[i]}, ";
    }
    return sum;
}

int[] array  = CreateArray(12, -9, 10);

System.Console.WriteLine(GetArray(array));
System.Console.WriteLine("Сумма положительных элементов равна = " + GetSumPositiveElementsFromArray(array));
System.Console.WriteLine("Сумма отрицательных элементов равна = " + GetSumNegativeElementsFromArray(array));





