//  По двум заданным числам проверить является ли первое квадратом второго
// int A = 4;
// int B = 16;
// if(A * A == B)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
//  _______________________________________________________________________
//  По заданному номеру дня недели вывести его название
// Console.WriteLine("Введите номер дня недели: ");
// string numberday = Console.ReadLine();

// switch(numberday)
// {
// case "1": Console.WriteLine("«Понедельник»"); break;
// case "2": Console.WriteLine("«Вторник»"); break;
// case "3": Console.WriteLine("«Среда»"); break;
// case "4": Console.WriteLine("«Четверг»"); break;
// case "5": Console.WriteLine("«Пятница»"); break;
// case "6": Console.WriteLine("«Суббота»"); break;
// case "7": Console.WriteLine("«Воскресенье»"); break;
// }
// ________________________________________________________________________
// Найти максимальное из трех чисел
// int a = 22;
// int b = 66;
// int c = 44;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.Write("max = ");
// Console.WriteLine(max);
// ________________________________________________________________________
// Выяснить является ли число чётным
// int n = new Random().Next(1, 33);
// if (n % 2 == 0)
// {
//     Console.WriteLine(n);
//     Console.WriteLine("Четно");
// }
// else
// {
//      Console.WriteLine(n);
//      Console.WriteLine("Нечетно");
// }
// _________________________________________________________________________
// Показать четные числа от 1 до N
// int n = 101;
// Console.Write("Четные числа: ");
// for(int a = 1; a < n; a++)
// {
//     if ( a % 2 == 0)
//     Console.Write(a + ", ");   
// }
// if (n % 2 == 0)
// {
//     Console.Write(n + ".");
// }
// else
// {
//     Console.Write("Finish.");
// }
// ___________________________________________________________________________
// Показать последнюю цифру трёхзначного числа
// int number = 123
// int a = (number % 10);
// Console.Write("Последняя цифра 3x значного числа: ");
// Console.WriteLine (a);
// ___________________________________________________________________________
// Показать вторую цифру трёхзначного числа
// Console.Write("Введите число n: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99)
// {
//     int a = (number % 100 / 10);
//     Console.Write("Вторая цифра заданного числа: ");
//     Console.WriteLine (a);
// }
// else
// {
//     Console.Write("Число не 3x значное");
// }
// ____________________________________________________________________________
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int n = new Random().Next(10, 99);
// int a1 = n / 10;
// int a2 = n % 10;
// if (a1 == a2)
// {
//     Console.WriteLine(n);
//     Console.WriteLine(a1);
//     Console.WriteLine("Все числа наибольшие");
// }

// else if (a1 > a2)
// {
//     Console.WriteLine(n);
//     Console.WriteLine(a1);
//     Console.WriteLine("Первое значение числа больше");
// }
// else
// {
//     Console.WriteLine(n);
//     Console.WriteLine(a2);
//     Console.WriteLine("Второе значение числа больше");
// }
// ___________________________________________________________________________
// Удалить вторую цифру трёхзначного числа
// Console.WriteLine("Введите трехзначное число n: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99)
// {
//     int newnumber = (number / 100 * 10 + number % 10); 
//     Console.Write("Полученное число:  ");
//     Console.WriteLine (newnumber);
// }
// else
// {
//     Console.Write("Число не трехзначное");
// }
// ____________________________________________________________________________

// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// int numberA = new Random().Next(51,201);
// int numberB = new Random().Next(1,51);
// int result = numberA % numberB;
// if (result == 0)
// {
//    Console.Write($"Число {numberA} кратно числу {numberB}");
// }
// else
// {
//    double ost = numberA % numberB;
//    Console.WriteLine($"Число {numberA} не кратно числу {numberB}");
//    Console.WriteLine("Остаток от деления: ");
//    Console.WriteLine(ost);
// }
// _____________________________________________________________________________
// Найти третью цифру числа или сообщить, что её нет
// int numberA = new Random().Next(99,1000);
// if (numberA > 99)
// {
//     int a = (numberA % 10);
//     Console.WriteLine(numberA);
//     Console.Write("Третья цифра заданного числа:  ");
//     Console.WriteLine (a);
// }
// int numberB = new Random().Next(999,2000);
// if (numberB >= 999)
// {
//     int a = ((numberB / 10) % 10);
//     Console.WriteLine(numberB);
//     Console.Write("Третья цифра заданного числа:  ");
//     Console.WriteLine (a);
// }
// int numberC = new Random().Next(1,100);
// if (numberC < 100)
// {
//     Console.WriteLine(numberC);
//     Console.Write("Число не имеет третьей цифры");
// }


