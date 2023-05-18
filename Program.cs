// 1.

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число A: ");
//         int a = int.Parse(Console.ReadLine());

//         Console.Write("Введите число B: ");
//         int b = int.Parse(Console.ReadLine());

//         int result = 1;
//         for (int i = 1; i <= b; i++)
//         {
//             result *= a;
//         }

//         Console.WriteLine($"Результат: {result}");
//     }
// }

// 2.

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }

//         Console.WriteLine($"Сумма цифр в числе: {sum}");
//     }
// }

// 3.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[] { 1, 2, 5, 7, 19 };
//         Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

//         int[] array2 = new int[] { 6, 1, 33 };
//         Console.WriteLine($"Массив: [{string.Join(", ", array2)}]");
//     }
// }