// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8);
System.Console.WriteLine($"[{String.Join(" ",Array)}]");

// -------------Method---------------
int[] GetArray(int size)
{
    int[] Array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(224222, 422242);
    }
    return Array;
}
