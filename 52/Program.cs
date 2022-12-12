// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] mid = new double[columns];
WriteLine();
mid = Average(array);
for(int i=0;i<mid.Length;i++)
{
    Write($"{mid[i]:f2} ");
}



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

double[] Average(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    double sum=0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[j,i];

        }
        arr[i]=sum/array.GetLength(0);
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}