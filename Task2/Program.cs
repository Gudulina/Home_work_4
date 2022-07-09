/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Summa(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }   
    return sum;
}

Console.WriteLine(Summa(452));
Console.WriteLine(Summa(82));
Console.WriteLine(Summa(9012));