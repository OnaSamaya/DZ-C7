// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

// Console.Write("Задайте начальное значение массива: ");
// int start = int.Parse(Console.ReadLine());

// Console.Write("Задайте конечное значение массива: ");
// int end = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в строке массива: ");
int indexRow = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в стоблце массива: ");
int indexColumn = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 10); //start, end

Console.WriteLine("");
PrintArray(myArray);
Console.WriteLine("");

if (indexRow>rows) Console.WriteLine("Такой позиции в массиве нет");
else if (indexColumn>columns) Console.WriteLine("Такой позиции в массиве нет");
else Console.WriteLine($"{myArray[indexRow, indexColumn] }");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
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
