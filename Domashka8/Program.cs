// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] ChangeRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//     for (int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             for (int k = j+1; k < array.GetLength(0); k++)
//             {
//                 if (array[i,j]>array[i,k])
//                 {
//                     int temp = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = (Create2DArray(min,max,rows,columns));
// Show2DArray(myArray);
// myArray = ChangeRows(myArray);
// Console.WriteLine();
// Show2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// int sumRows(int[,] array,int i)
// {
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i,j];
//   }
//   return sum;
// }

// void minSum(int[,] array)
// {
//     int minNum = 0;
//     int sum = sumRows(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
// {
//     int temp = sumRows(array,i);
//     if (sum>temp)
//     {
//         sum = temp;
//         minNum = i;
//     }
// }
// Console.WriteLine($"{minNum+1} - номер строки с наименьшей суммой элементов");
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
// minSum(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

// int[,] multiMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//               arrayC[i, j] += arrayA[i, k] * arrayB[k, j];  
//             }
//         }
//     }
//     return arrayC;
// }

// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк 1 матрицы");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1 матрицы");
// int columnsA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк 2 матрицы");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 2 матрицы");
// int columnsB = Convert.ToInt32(Console.ReadLine());

// int[,] arrayA = (Create2DArray(min,max,rowsA,columnsA));
// int[,] arrayB = (Create2DArray(min,max,rowsB,columnsB));

// Show2DArray(arrayA);
// Console.WriteLine();
// Show2DArray(arrayB);
// Console.WriteLine();
// Show2DArray(multiMatrix(arrayA,arrayB));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите размеры массива 'x' x 'y' x 'z' через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = Create3DArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
// Show3DArray(array);

// int[,,] Create3DArray(int[] sizes, int minValue, int maxValue)
// {
//     int[,,] newArray = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < newArray.GetLength(2))
//             {
//                 int element = new Random().Next(minValue, maxValue + 1);
//                 if (FindElement(newArray, element)) continue;
//                 newArray[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return newArray;
// }

//  bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


