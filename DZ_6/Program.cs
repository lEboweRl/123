// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// Console.WriteLine(" Введите k1: ");
// int k1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine(" Введите b1: ");
// int b1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine(" Введите k2: ");
// int k2 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine(" Введите b2: ");
// int b2 = int.Parse(Console.ReadLine() ?? "0");

// if (k1 == k2) Console.WriteLine(" Прямые параллельны❗️");
// else
// {
//     int x = (b2 - b1) / (k1 - k2);
//     int y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
//     Console.WriteLine($" Точки пересечения x({x}); y({y})");
// }
//___________________________________________________________________________________________________________________
// Показать числа Фибоначчи
int Fibonachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}
// int n1 = Fibonachi(5);
// int n2 = Fibonachi(6);
// int n3 = Fibonachi(8);
// Console.WriteLine($" число Фибоначчи (5): {Fibonachi(5)}");
// Console.WriteLine($" число Фибоначчи (6): {Fibonachi(6)}");
// Console.WriteLine($" число Фибоначчи (8): {Fibonachi(8)}");
Console.WriteLine(" Введите искомое число Фибоначчи: ");
int Num = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Num; i++)
{
    Console.WriteLine($"number of fibonachi({i}) = {Fibonachi(i)}");
}
//____________________________________________________________________________________________________________________

//____________________________________________________________________________________________________________________
// Написать программу копирования массива
// void FillArray(int[] array, int min, int max)
// {
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
// }
// void PrintArray(int[] array)
// {
//     Console.Write("array = {");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.WriteLine(array[array.Length - 1] + "}");
// }
// void CopyArray(int[] array)
// {
//     int[] Copy = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Copy[i] = array[i];
//         Console.Write(Copy[i]);
//     }
// }
// Console.WriteLine("Размер массива: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();
// int[] array = new int[size];
// FillArray(array, 10, 30);
// Console.WriteLine($" Наш исходный массив: ");
// PrintArray (array);
// Console.WriteLine();
// Console.WriteLine($" Скопированный массив:  ");
// CopyArray(array);