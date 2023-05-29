// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation (int a, int b) {
//     int result = 1;
//     for (int count = 0; count < b; count++) {
//         result = result * a;
//     }
//     return result;
// }

// System.Console.WriteLine("Input number a");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number b");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"The exponention of {a} in {b} -> {Exponentiation(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum (int a) {
//     int result = 0;
//     while (a > 0) {
//         result = result + a % 10;
//         a = a / 10;
//     }
//     return result;
// }

// int InputNum (string message) {
//     System.Console.WriteLine("Input number a = ");
//     string inputNum = Console.ReadLine();
//     int a = Int32.Parse(inputNum);
//     return a;
// }

// int a = InputNum ("InputNUm");
// System.Console.WriteLine($"Sum of digits in {a} -> {Sum(a)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] CreateRandomArray (int minValue, int maxValue) {
//     int[] newArray = new int[8];
//     for (int i = 0; i < newArray.Length; i++) {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void PrintArray (int[] array) {
//     foreach (int i in array) {
//         Console.Write(i + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input min value");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max value");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(minValue, maxValue);

// PrintArray(myArray);