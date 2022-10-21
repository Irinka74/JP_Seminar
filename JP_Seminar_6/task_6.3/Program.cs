// Напишите программу, которая будет преобразовывать десятичное число в двоичное

string DecNumber(int number)
{
	string result = string.Empty;

	while (number > 0)
	{
		result += number % 2;
		number /= 2;
		Console.WriteLine(number);
	}

	return result;
}

Console.WriteLine(DecNumber(45));
