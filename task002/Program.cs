/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
System.Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цыфр числа {A} Равняется {GetSumFigure(A)}");

//---------------Method--------------
int GetSumFigure(int limit)
{
    int Sum = 0;
    int Figure = 0;
       while (limit > 0)
    {
                Figure = limit % 10;
                limit = limit / 10;
                Sum = Sum +  Figure;
    }
    return Sum;
}

