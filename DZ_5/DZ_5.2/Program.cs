// // II. Реализовать следующие функции:
// // 1. Функцию, которая вычисляет число a в степени 
// int Stepen(int degree, int number)
// {
//     int NewNumber = 1;
//     for (int i = 0; i < degree; i++) NewNumber *= number;
//     Console.WriteLine($"Число {number} в степени {degree} равно {NewNumber}");
//     return NewNumber;
// }
// Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("В какую степень возвести число?: ");
// int deg = int.Parse(Console.ReadLine() ?? "0");
// Stepen(deg, num);
// // _________________________________________________________________________________
// // 2. Функцию, которая вычисляет факториал числа n
// int Factorial(int N)
// {
//     int F = 1;
//     for (int i = 1; i <= N; i++)
//         F *= i;
//     return F;
// }
// Console.WriteLine("Введите число искомого факториала: ");
// int N = int.Parse(Console.ReadLine() ?? "0");
// int f = Factorial(N);
// Console.WriteLine($"Факториал числа {N} равен " + f);
// // _________________________________________________________________________________
// // 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
// int SumNumeral(int n)
// {
//     int sum = 0;
//     for (int i = 0; i < n; i++)
//         if (n > 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//    return sum;
// }
// Random rand = new Random();
// int n = rand.Next(20, 40);
// Console.WriteLine($"Сумма чисел в числе {n} = {SumNumeral(n)}" );
// // _________________________________________________________________________________
// // 4. Функцию, которая проверяет является ли заданное число n пaлиндромом
// bool Palindrome(string num)
// {
//     for (int i = 0; i < num.Length / 2; i++)
//         if (num[i] != num[num.Length - i - 1])
//             return false;
//     return true;
// }
// Console.Write("Введите число и узнаем, является ли оно полиндромом ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// string num = number.ToString();
// bool palindrom = Palindrome(num);
// Console.WriteLine(palindrom);
// // _________________________________________________________________________________
// // 5. Функцию, складывающую два целых числа
// int SumNumbers(int numberA, int numberB)
// {
//     int newNumber = 0;
//     if (numberA % 1 == 0 && numberB % 1 == 0) newNumber = numberA + numberB;
//     return newNumber;
// }
// Console.WriteLine("Введите число №1: ");
// int numberA = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите число №2: ");
// int numberB = int.Parse(Console.ReadLine() ?? "0");
// int sum = SumNumbers(numberA, numberB);
// Console.WriteLine($"Сумма чисел {numberA} и {numberB} равна: {sum}");
// // _________________________________________________________________________________
// // 6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
// bool Number(int n)
// {
//     for (int i = 2; i < n; i++)
//         if (n % i == 0) return false;
//     return true;
// }
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Число простое? ");
// bool num = Number(n);
// Console.WriteLine(num);
// // _________________________________________________________________________________
// // 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
bool ChetNumber(int number)
{
    if (number % 2 == 0) return true;
    return false;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Если число чётное - true, иначе - false >>>>>>>>>>> [{ChetNumber(number)}] <<<<<<<<<<<<");