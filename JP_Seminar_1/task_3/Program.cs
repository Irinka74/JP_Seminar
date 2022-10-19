// Программа, которая выдает название дня недели по заданному номеру (6-> суббота)

Console.WriteLine("введите число от 1 до 7");

string n = Console.ReadLine();
int a = int.Parse(n);
if(a == 1) Console.WriteLine("понедельник");
if(a == 2) Console.WriteLine("вторник");
if(a == 3) Console.WriteLine("среда");
if(a == 4) Console.WriteLine("четверг");
if(a == 5) Console.WriteLine("пятница");
if(a == 6) Console.WriteLine("суббота");
if(a == 7) Console.WriteLine("воскресенье");
