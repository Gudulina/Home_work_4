/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Оформите программу ввиде функций (пригодится в дальнейшем)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] Array()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }    
    return arr;
}


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


int[] arr_1 = Array();
Print(arr_1);

int[] arr_2 = Array();
Print(arr_2);
