// Программа, которая принимает на вход число и выдает количество цифр в числе
// 456 = 3цифры

Console.Write("Введите число N = ");
int count = int.Parse(Console.ReadLine());
Console.Write(GetLenght(count));

int GetLenght(int count)
{

int sum = 0;
   while (true )
    {
     if(count == 0) break;
     count = count/10;
     sum ++;
    }
return sum;
}
