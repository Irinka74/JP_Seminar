// Задайте двухмерный массив размера m на n
//Выведите полученный массив на экран

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
} 
     
string ArrayToString(int[,] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine;
	}

	return result;
}