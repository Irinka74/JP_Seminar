// задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -

int[] CreateArray(int size, int min, int max) 
{ int[] array = new int[size];
 Random rnd = new Random(); 
 for (int i = 0; i < size; i++) 
 { array[i] = rnd.Next(min, max); 
 }
    return array;
}
int Qelements(int[] array)
{int counter = 0;
    
    foreach (int element in array)
    {
        if ( element > 9 & element < 99) counter ++;    }
    return counter;
}
string GetArray1(int[] array) 
{ 
    string sum = string.Empty; 
    for (int i = 0; i < array.Length; i++) 
    { 
        sum = sum + $"{array[i]}, "; 
    }
        
         return sum; 
}
int[] array = CreateArray(123, -150, 150);
System.Console.WriteLine(GetArray1(array));
System.Console.WriteLine(Qelements(array));
