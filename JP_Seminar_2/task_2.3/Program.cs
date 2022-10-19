// программа, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления (34,5 -> не кратно остаток 4
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = a % b;
if ( a% b == 0)
{
  Console.WriteLine("Успешно");  
}
else
{
  Console.Write("Остаток от деления: " );   
 Console.Write( result );    
}