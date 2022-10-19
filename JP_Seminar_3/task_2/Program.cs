// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у)

Console.Write( "введите номер четверти"  );
int_number = int.Parse(Console.ReadLine());

int x  = 0;
int y  = 0;
int [,] array = new int[4, 2];

array [0, 0] = 1;
array [0, 1] = 1;

array [1, 0] = - 1;
array [1, 1] = 1;

array [2, 0] = - 1;
array [2, 1] = - 1;

array [3, 0] = 1;
array [3, 1] = - 1;

int minx = array [number -1, 0];
int miny = array [number -1, 1];
string maxy = "";
string maxx = "";
 if(x  > 0)
    {
      maxx = "infinity";
    }
    else 
    {
       maxx = ("- infinity");
    }
     if (miny > 0)
    {
      maxy = ("infinity"); 
    }
    else 
    {
       maxy = ("- infinity");
    }
Console.WriteLine($"from x = {minx} to x = {int.maxx}");
Console.WriteLine($"from y = {miny} to y = {int.maxy}");



