//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// int[] array = {0, 1, 0, 1, 1, 0, 0, 1};
// Console.Write("{");
// for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
// Console.WriteLine(array[array.Length - 1] + "}");
// ________________________________________________________________________________
// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// int[] array = new int[12];
// Random number = new Random();
// int SumNegative = 0;
// int SumPositive = 0;
// Console.Write("array = {");
// for (int i = 0; i < array.Length - 1; i++) 
// {
//     array[i] = number.Next(-9, 10);
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine(array[array.Length - 1] + "}");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Element {0} = {1}", i + 1, array[i]);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if( array[i] > 0) SumPositive += array[i];
//     else SumNegative += array[i];
// }
// Console.WriteLine($"Сумма положительных элементов  в массиве =  {SumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов в массиве = {SumNegative}");
// __________________________________________________________________________________
// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// Console.WriteLine("Введите размер массива: ");
// int size_array = int.Parse(Console.ReadLine() ?? "0");
// int[] array = new int[size_array];
// Random number = new Random();
// Console.WriteLine("Сформированный массив: ");
// FillArrayRandomNum(array);
// PrintArray(array);
// int countA = 0;
// int countB = 0;
// void FillArrayRandomNum(int[] array) //заполнение массива
// {
//     for (int i = 0; i < array.Length; i++)  array[i] = number.Next(100, 1000);
// }
// void PrintArray(int[] array) //вывод строкой
// {
//     Console.Write("array = {");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.WriteLine(array[array.Length - 1] + "}");
// }
// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i] % 2 == 0) // четное
//     {
//         countA++;
//     }
//     else // нечетное
//     {
//         countB++;
//     }
// }
// Console.WriteLine($"Кол-во четных чисел в массиве: {countA}");
// Console.WriteLine($"Кол-во нечетных чисел в массиве:  {countB}");
// ____________________________________________________________________________________
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// void FillArray(int[] array, int min, int max) //заполнение массива
// {
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min,max);
// }
// void PrintArray(int[] array) //вывод строкой
// {
//     Console.Write("array = {");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.WriteLine(array[array.Length - 1] + "}");
// }
// int[] array = new int[123];
// Console.WriteLine("Сформированный массив из 123 чисел: ");
// Console.WriteLine();
// FillArray(array, 0,100);
// PrintArray(array);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Кол-во элементов из отрезка 10 - 99 равно {count}");
// Console.WriteLine();
// ____________________________________________________________________________________
//Найти сумму чисел одномерного массива стоящих на нечетной позиции
// void FillArray(int[] array, int min, int max) //заполнение массива
// {
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
// }
// void PrintArray(int[] array) //вывод строкой
// {
//     Console.Write("array = {");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.WriteLine(array[array.Length - 1] + "}");
// }
// int[] array = new int[9];
// FillArray(array, 0, 100);
// Console.WriteLine($"Сформированный массив из 9-х чисел: ");
// PrintArray(array);
// int SumNumbers = 0;
// for (int i = 1; i < array.Length; i = i + 2) SumNumbers += array[i];
// Console.WriteLine($"Сумма чисел на нечетных позициях равна {SumNumbers}");
// ___________________________________________________________________________________
// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] array = new int[10]; 
// void FillArray(int[] array, int min, int max) 
// { 
//     for (int i = 0; i < array.Length; i++) 
//     array[i] = new Random().Next(min, max); 
// } 
// void PrintArray (int[] array) 
// {
//     Console.Write("array = {");
//     for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
//     Console.WriteLine(array[array.Length - 1] + "}");
// } 
// FillArray(array, 0, 12); 
// Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |"); 
// Console.Write($"  Сформированный массив: "); 
// PrintArray(array); 
// Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |"); 
// for (int i = 0; i < array.Length/2; i++) 
// { 
//     int multiplication = 0; 
//     multiplication = array[i] * array[array.Length - i - 1]; 
//     Console.WriteLine($"para of Elements № {1 + i} --- {array[i]} * {array[array.Length - i - 1]} = {multiplication}"); 
// }
// ___________________________________________________________________________________
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// double[] array = new double[20];
// for (int i = 0; i < array.Length; i++) array[i] = new Random().NextDouble()*10;
// double max = array[0], min = array[0];

// for (int i = 1; i < array.Length; i++) if (array[i] > max) max = array[i];
// for (int i = 1; i < array.Length; i++) if (array[i] < min) min = array[i];

// for (int i = 0; i < array.Length; i++) 
// Console.WriteLine(" " + array[i]);
// Console.WriteLine();
// Console.WriteLine("Максимальное значение:  " + max);
// Console.WriteLine("Минимальное значение:  " + min);
// Console.WriteLine("Разница максимального и минимального значения:  " + (max - min));