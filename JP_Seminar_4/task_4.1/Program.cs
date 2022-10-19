// Программа, которая принимает на вход число А
// и выдает сумму чисел от 1 до А

Console.Write("Введите число N = ");
int count = int.Parse(Console.ReadLine());
Console.Write(GetSum(count));

int GetSum(int count)
{

int sum = 0;
    for(int i = 0; i <= count; i++)
    {
     sum += i;
    }
return sum;
}