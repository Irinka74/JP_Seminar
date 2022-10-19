// Программа, которая на вход принимает одно число(N)
//а на выходе показывает все целые числа в промежутке от N до -N 

int Sa = int.Parse(Console.ReadLine());
int i = Sa;
if (Sa < 0)
{
    while (i <= Math.Abs(Sa))
    {
    Console.WriteLine(i);  
       i++;
    }
}
else 
{
 i = -Sa;
 while (i <= Sa)

   {   
   Console.WriteLine(i);  
   i++; 
    } 
  }   


 
