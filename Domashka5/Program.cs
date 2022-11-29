// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateRandomArray(int size, int minValue,int maxValue)  
// {
// int [] newArray = new int [size]; 

//     for(int i=0;i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindCount (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2 == 0) count++;
//     }
//     Console.WriteLine($"Количество четных чисел равно -> {count}");
// }

// Console.WriteLine("Введите размер массива"); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите минимальное значение массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a,min,max);
// ShowArray(myArray);
// FindCount(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int size, int minValue,int maxValue)  
// {
// int [] newArray = new int [size]; 

//     for(int i=0;i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindSum (int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum = sum + array[i];
//     }
//     Console.WriteLine($"Сумма чисел на нечетных позициях равна -> {sum}");
// }

// Console.WriteLine("Введите размер массива"); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите минимальное значение массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a,min,max);
// ShowArray(myArray);
// FindSum(myArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Double [] CreateRandomArray(int size, double minValue,double maxValue)  
// {
// double [] newArray = new double [size]; 
// Random rand = new Random();
//     for(int i=0;i < size; i++)
//     {
//         newArray[i] = minValue + rand.NextDouble() * (maxValue - minValue);

//     }
//     return newArray;
// }

// void ShowArray(double [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindMaxMin (double[] array)
// {
//     double max = 0;
//     double min = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>max) max = array[i];
//         else if(array[i]<min) min = array[i]; 
//     }
//     Console.WriteLine("\nМинимальный элемент: " + min);
//     Console.WriteLine("Максимальный элемент: " + max);
//     Console.WriteLine("Разница максимального и минимального равна ->"+(max-min));
// }

// Console.WriteLine("Введите размер массива"); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите минимальное значение массива:");
// double minv = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива:");
// double maxv = Convert.ToInt32(Console.ReadLine());
// double[] myArray = CreateRandomArray(a,minv,maxv);
// ShowArray(myArray);
// FindMaxMin(myArray);
