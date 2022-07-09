/* 
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Degree(int a, int b)
{
    int mult = a;

    for (int i = 1; i < b; i++)
    {
        mult *= a;
    }
    return mult;
}

Console.WriteLine(Degree(3, 5));
Console.WriteLine(Degree(2, 4));