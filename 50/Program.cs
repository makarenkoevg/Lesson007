//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

Write("Введите индекс строки: ");
int row = int.Parse(ReadLine());

Write("Введите индекс столбца: ");
int column = int.Parse(ReadLine());


double [,] GetArray(int m, int n, int min, int max)
{
    double [,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min)+min;
          
        }

    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]:f3} ");
        }
        WriteLine();
    }
}

double [,] array = GetArray(10,10,-10,10);
if ((row>array.GetLength(0)-1) || (row<0) || (column>array.GetLength(1)-1) || (column<0))
{
    WriteLine("Такого элемента нет в массиве!");
}
else {
    WriteLine($"Значение элемента: {array[row,column]:f3}");
    PrintArray(array);
}