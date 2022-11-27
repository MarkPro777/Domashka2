// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Main (int a, int b)
// {
//     int s = 1;
//     for (int i=0; i<b; i++)
//     {
//         s*=a;
//     }
//     return s;
// }
// Console.Write("Введите число : ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень : ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = Main(numberA,numberB);
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int FindSum (int num)
// {
//     int sum = 0;
//     while (num>0)
//     {
//         int digit = num%10;
//         sum+=digit;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(number));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         newArray[i] = new Random().Next(minValue,maxValue);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write($" -> [ ");
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.Write("]");
// }
//Console.WriteLine("Введите размер массива"); //у нас задано 8 элементов
//int a = Convert.ToInt32(Console.ReadLine()); //у нас задано 8 элементов
// Console.WriteLine("Введите минимальное значение массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(8,min,max);
// ShowArray(myArray);