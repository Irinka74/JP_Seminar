// Программа, которая выводит массив из 8 элементов, заполненый нулями и единицами в случайном порядке {1;0;1;1;0;1;0;0}
Massiv();
void Massiv()
{
   int [] N = new int [8]; 
    Console.Write("Массив [ ");

    for (int i = 0; i < N.Length; i++)
    {
    N[i] = new Random().Next(0,2);  
    Console.Write($" {N[i]}");
    }

    Console.Write("Массив ] ");
}
