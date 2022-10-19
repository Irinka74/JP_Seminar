//На вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("введите число ");
string Sa = Console.ReadLine();
Console.WriteLine("введите число ");
string Sb = Console.ReadLine();
int a = int.Parse(Sa);
int b = int.Parse(Sb);
 if ( a == b * b)
   {
     Console.WriteLine("да"); 
   }
  else
  {
   Console.WriteLine("нет");
  } 
