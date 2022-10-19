// Программа, которая принимает на вход число N и выдает произведение чисел от 1 до N
//4 -24; 5 - 120
Console.Write("Введите число N = ");
int Number = int.Parse(Console.ReadLine());
Console.Write($" Факториал числа {Number} равен {GetF(Number)}");

int GetF(int Number)
{

int F = 1;
 for (int i = 1; i <= Number; i++ )
    {
     F = F * i;
    }
return F;
}

