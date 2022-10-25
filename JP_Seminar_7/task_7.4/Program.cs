// Задайте двухмерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами(0,0); (1;1))

int GetDiaganolSumm(int[,] array)
{
	int sum = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (i == j)
				sum += array[i, j];
		}
	}

	return sum;
}

