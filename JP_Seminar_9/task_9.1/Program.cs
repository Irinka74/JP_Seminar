// Задача 63. Задайте значение N. Напишите прграмму, которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());

void FindNumber (int a)
{
 if (a == 1) {System.Console.WriteLine(a); return;}   
FindNumber (a-1);
System.Console.WriteLine(a);
}

FindNumber(m);


