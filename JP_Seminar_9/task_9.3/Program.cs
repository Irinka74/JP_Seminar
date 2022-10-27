
//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


Console.WriteLine("enter A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B: ");
int B = int.Parse(Console.ReadLine());

int degreeNatural (int a, int b)
{
    if (b == 0) return a;
    return degreeNatural (a, b-1) * a;
}

System.Console.WriteLine(degreeNatural(A, B));
