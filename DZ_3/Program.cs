//Найти кубы чисел от 1 до N
// Console.WriteLine("Введите интервал, в котором определим кубы чисел");
// Console.Write("Введите число №1: ");
// int a = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите число №2: ");
// int N = int.Parse(Console.ReadLine() ?? "0");

// while (a <= N) 
// {
//     Console.WriteLine($"Число {a - 1} в кубе = {a * a * a}");
//     a++;
// }
// ____________________________________________________________________________
// Подсчитать сумму цифр в числе
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// int sum = 0;
// while (number > 0)
// {
//     sum = sum + number % 10;
//     number = number / 10;
// }
// Console.WriteLine(sum);
// ____________________________________________________________________________
// Написать программу вычисления произведения чисел от 1 до N
// Console.WriteLine("Введите число искомого факториала: ");
// int N = int.Parse(Console.ReadLine() ?? "0");
// int i = 1;
// int Factorial = 1;
// while (i <= N)
// {
//     Factorial = Factorial * i;
//     i++;
// }
// Console.WriteLine(Factorial);
// ____________________________________________________________________________
// Показать кубы чисел, заканчивающихся на четную цифру
// Console.WriteLine("Введите число A: ");
// int A = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine() ?? "0");
// if(A > B)
// {
//     int temp = B;
//     B = A;
//     A = temp;
// }
// while(A <= B) 
// {
//     int cube = A * A * A;
//     if(cube % 2 == 0) Console.WriteLine($" Куб числа {A} = {cube} данный куб заканчивается на четную цифру");
//     A++;
// }
// _____________________________________________________________________________
