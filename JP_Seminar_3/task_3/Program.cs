//Программа, которая принимает на вход координаты двух точек и находит растояние между ними в 2д

Console.Write( "введите х1 "  );
int x1 = int.Parse(Console.ReadLine());
Console.Write( "введите y1 "  );
int y1 = int.Parse(Console.ReadLine());

Console.Write( "введите х2 "  );
int x2 = int.Parse(Console.ReadLine());
Console.Write( "введите y2 "  );
int y2 = int.Parse(Console.ReadLine());

int[,] array = new int[2, 2];
array [0, 0] = x1;
array [0, 1] = y1;

array [1, 0] = x2;
array [1, 1] = y2;
double r = Math.Sqrt(Math.Pow((array [0, 0] - array [0, 1]),2) + Math.Pow((array [0, 1] - array [1, 1]),2));

Console.WriteLine($"Длина {r} ");


