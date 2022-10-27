// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9


Console.WriteLine("enter m: ");
	int m = int.Parse(Console.ReadLine());
	
	int digitsSum(int N)
	{
	    if (N / 10 == 0) return N;
	    return N % 10 + digitsSum(N / 10);
	}
	
	System.Console.WriteLine(digitsSum(m));