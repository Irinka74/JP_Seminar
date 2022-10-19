// Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа (456->46)

int number = new Random().Next(100, 999);
Console.WriteLine(number);
int firstNumber = 0;
int secondNumber = 0;
int thirdNumber = 0;

firstNumber = number / 100;
thirdNumber = number % 10;

Console.Write(firstNumber * 10 + thirdNumber);



