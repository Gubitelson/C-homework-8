﻿/* Задача 56 
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */
void PrintArray(int[,] inArray) //Отображение массива 

{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue) //Создание массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
int[,] array = GetArray(5, 4, 1, 9);            //Задали массив
void MinSummStringInArray(int[,] array) //Отображение строки с мин суммой
{
    int min = 0;
    int sum = 0;
    int num = 1;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            sum += array[row, coll];
        }
        Console.Write($"Сумма {row + 1} строки = {sum};\n");
        if (min == 0) min = sum;
        else if (min > sum)
        {
            min = sum;
            num = row + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма в {num}-й строке");
}
//array создалвал с помощью GetArray()
PrintArray(array);                              //Отобразили

MinSummStringInArray(array);
Console.WriteLine();