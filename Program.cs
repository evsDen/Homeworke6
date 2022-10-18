// // task 34

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// int CountEventNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++; // count = count + 1
//     }
//     return count;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Кол-во четных элементов: {CountEventNumbers(array)}");

// // task 36

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-10, 11);
// }

// int CountEventNumbers(int[] array)
// {
//     int summa = 0;
//     for (int i = 1; i < array.Length; i+=2) // i = i + 2
//         summa = summa + array[i];
//     return summa;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма элементов на нечетных позициях: {CountEventNumbers(array)}");



// // task 38

// void InputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * 10, 3);
// }

// double CountEventNumbers(double[] array)
// {
//     double minArray = array[0], maxArray = array[0];
//     for (int i = 1; i < array.Length; i++) // i = i + 2
//     {
//         if (maxArray < array[i])
//             maxArray = array[i];
//         else if (minArray > array[i])
//             minArray = array[i];
//     }
//     return maxArray - minArray;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Разница между макс и мин: {CountEventNumbers(array)}");



// // second Max

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int firstMax = n, secondMax = -1;

// while (n != 0)
// {
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n > firstMax)
//     {
//         secondMax = firstMax;
//         firstMax = n;
//     }
//     else if (n > secondMax)
//         secondMax = n;
// }
// Console.WriteLine(secondMax);



// // SuperStep

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// int[] arrayResult = new int[n];
// int k = Convert.ToInt32(Console.ReadLine());
// k = k % n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         arrayResult[i] = array[n - k + i];
//     for (int i = 0; i < n - k; i++)
//         arrayResult[k + i] = array[i];
    
//     Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }
// else
// {
//     k = k * (-1);
//     for (int i = 0; i < k; i++)
//         arrayResult[n - k + i] = array[i];
//     for (int i = 0; i < n - k; i++)
//         arrayResult[i] = array[k + i];
    
//     Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }


// // 39 task Разворот массива

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10);
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// // 40 task Треугольник ли это?

// Console.Clear();
// Console.Write("Введите 1-ую сторону треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ую сторону треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-ю сторону треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");




// //  Task 42  Перевод из 10 системы счисления в двоичное
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (n > 0)
// {
//     int x = n % 2;
//     result = Convert.ToString(x) + result;
//     n = n / 2;
// }
// Console.WriteLine(result);
// // Решение 42 задачи через рекурсию
// string f(int n)
// {
//     if (n == 0 || n == 1)
//         return $"{n}";
//     return f(n / 2) + $"{n % 2}";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));



// // Task 44 Числа Фибоначчи
//  Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");
//     int x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }


// // Task 45
// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// int[] b = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
//     b[i] = array[i];
    
// b[0] = -10;
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"[{string.Join(", ", b)}]");
