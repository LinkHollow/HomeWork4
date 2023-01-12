/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
(Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16  */
System.Console.WriteLine("Введите Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Число B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{A} в степени {B} равняется: {GetDegree(A,B)}");

//---------------Method--------------
int GetDegree(int X, int Y)
{
    int D = 1;
    for(int i = 0; i < Y; i++)
    {
       D = X * D;
    }
    return D;
}