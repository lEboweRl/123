// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Console.WriteLine("Выясним выходной по номеру дня недели? Введите номер (от 1 до 7): ");
// int day_number = Convert.ToInt32(Console.ReadLine());
// if(day_number > 5 && day_number < 8) Console.WriteLine ("Ура-ура-ура! Это выходной!!!");
// else if(day_number > 7) Console.WriteLine("Такого дня недели нет!!!");
// else Console.WriteLine("К сожалению, Вы выбрали рабочий день недели");
// __________________________________________________________________________________________
// По двум заданным числам проверять является ли одно квадратом другого
// int n1 = 4;
// int n2 = 2;
// if(n1 * n1 == n2)
// {
//     Console.WriteLine($"Число {n1} является квадратом числа {n2}");
// }
// else if(n2 * n2 == n1)
// {
//     Console.WriteLine($"Число {n2} является квадратом числа {n1}");
// } 
// else Console.WriteLine ("Числа не являются квадратом друг друга");
// __________________________________________________________________________________________
// Задать номер четверти, показать диапазоны для возможных координат
// Console.Write ("Введите номер четверти: ");
// int h = int.Parse(Console.ReadLine () ?? "0");
// if (h == 1)
// {
//     Console.Write ("(x > 0); (y > 0)");
// }
// else if (h == 2)
// {
// Console.Write("(x < 0); (y > 0)");
// }
// else if (h == 3)
// {
//     Console.Write("(x < 0); (y < 0)");
// }
// else if (h == 4)
// {
//     Console.Write("(x > 0); (y < 0)");
// }
// else Console.WriteLine("WARNING!WARNING!WARNING! This number is not available now, try to call back later");
// _____________________________________________________________________________________________
// Найти расстояние между точками в пространстве 2D/3D
// int x1 = new Random().Next(0,30);
// int y1 = new Random().Next(0,30);
// int z1 = new Random().Next(0,30);

// int x2 = new Random().Next(0,30);
// int y2 = new Random().Next(0,30);
// int z2 = new Random().Next(0,30);

// double space2D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2));
// Console.WriteLine($"Расстояние между точками в пространстве 2D A: {x1}, {y1}, B: {x2}, {y2})  =  {space2D}");

// double space3D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2) + Math.Pow((z2-z1),2));
// Console.WriteLine($"Расстояние между точками в пространстве 2D A: {x1}, {y1}, {z1} B: {x2}, {y2}, {z2})  =  {space3D}");