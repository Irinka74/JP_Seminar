// Программа, которая выводит случайное число из отрезка(10,99) и показывает наибольшую цифру числа

int number = new Random().Next(10, 99);
Console.WriteLine(number);
int firstNumber = 0;
int secondNumber = 0;

firstNumber = number / 10;
secondNumber = number % 10;
if (firstNumber > secondNumber)
  {  Console.WriteLine(firstNumber); 
  }
else

{
    Console.WriteLine(secondNumber);
}


