// 65.Задайте значения M и N. Напишите прграмму, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());


void FindNumber (int a, int b)
{
 if (a > b) {System.Console.WriteLine("Ошибка ввода"); return;}
 else 
 if (a == b) {System.Console.WriteLine(a); return;}   
FindNumber (a, b-1);
System.Console.WriteLine(b);
}

FindNumber(n, m);

/* второй вариант
using System.Text;

StringBuilder GetNumbers(int i, StringBuilder sb = null)
{
	if (sb is null)
	{
		sb = new StringBuilder();
	}

	if (i == 1)
	{
		sb.Append(i.ToString() + " ");
		return sb;
	}

	GetNumbers(i - 1, sb);
	sb.Append(i.ToString() + " ");

	return sb;
}

Console.WriteLine(GetNumbers(5).ToString());
