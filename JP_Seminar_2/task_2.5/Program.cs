// Программа, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого (5,25 – да)

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if ( a == b * b )
{
  Console.WriteLine("Число является квадратом другого");  
}
else
{
  Console.WriteLine("Число не является квадратом другого");   
}

