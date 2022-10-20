// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < m; i++) 
// {
//      Console.Write("Введите число: ");
//      int n = Convert.ToInt32(Console.ReadLine());
//     if (n > 0)
//     count = count +1;
// }
// Console.WriteLine($"Количество положительных чисел: {count}");



// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.Clear();
// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1)/(k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения прямых: ({x};{y})");