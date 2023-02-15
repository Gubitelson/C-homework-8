﻿/* Задача №60 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2 
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/



int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue) //создание трехмерного массива
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArrayThird(int[,,] inArray) //Отображение трехмерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}

int[,,] arrayThird = GetThirdArray(4, 4, 4, 10, 100); //Трехмерный массив
PrintArrayThird(arrayThird);                          //Отображение трехмерного массива