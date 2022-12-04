// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void FindCount (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) count++;
//     }
//     Console.WriteLine($"Количество чисел больше нуля -> {count}");
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

// int[] StringToNum(string input)
// {
//     int size = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             size++;
//         }
//     }
// int [] newArray = new int [size]; 
// int index = 0;
// for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         newArray[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return newArray;   
// }

// Console.Write("Введите числа через запятую:");
// int[] myArray = StringToNum(Console.ReadLine());

// ShowArray(myArray);
// FindCount(myArray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"точка пересечения: ({x};{y})");