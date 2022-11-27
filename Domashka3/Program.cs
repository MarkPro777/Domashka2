// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число"); 
// string s = Console.ReadLine(); 

// bool palindrome = true; 
// 	int n = s.Length; 
// 		for(int i = 0; i < n / 2; i++)
// 		{
// 			if(s[i] != s[n - 1 - i]) 
// 				palindrome = false;
// 		}
		
// 	if(palindrome == true)
// 		{
// 			Console.WriteLine(s + "->да");
// 		}
// 	else Console.WriteLine(s + "->нет");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }
// Console.WriteLine($"Введите координату x1 ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите координату y1 ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите координату z1 ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите координату x2 ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите координату y2 ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите координату z2 ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double GetLens(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//   return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
// }

// double segmentLength =  Math.Round (GetLens(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Расстояние между точками ->  {segmentLength}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(int N)
// {
//  for (int i = 1; i <= N; i++)
//  {
//     Console.WriteLine($"{i} -> {i*i*i}");
//  }
// }
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Cube(N);