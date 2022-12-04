// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DArray (double minValue, double maxValue, int rows, int columns)
// {
//     double[,] newArray = new double[rows,columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j]= minValue + rand.NextDouble() * (maxValue - minValue);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите минимальное значение");
// double min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// double max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк m:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов n:");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] array = (Create2DArray(min,max,rows,columns));
// Show2DArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DArray (int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows,columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j]= new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите номер строки искомого элемента");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца искомого элемента");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = (Create2DArray(min,max,rows,columns));
// Show2DArray(array);

// void FindNum(int[,] array,int a,int b)
// {
//     if (a>rows && b>columns)
//     Console.WriteLine("такого элемента нет");
//     else
//     Console.WriteLine(array[a,b]);
// }
// FindNum(array,a,b);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DArray (int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows,columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j]=  new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindAverage(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         {
//             double sum = 0;
//             int i = 0;
//             while (i < array.GetLength(0))
//             {
//                 sum = sum + array[i,j];
//                 i++;
//             }
//             Console.Write($"{Math.Round(sum / i, 2)};");
//         }
//         Console.WriteLine();
// }

// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = (Create2DArray(min,max,rows,columns));
// Show2DArray(array);
// FindAverage(array);