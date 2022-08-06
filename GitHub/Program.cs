//                        ЗАДАЧИ НА УРОКЕ

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// % - деление с остатком (выводится остаток от деления)
// / - обычное деление чисел





// Напишите программу, которая на вход принимает число и выдает его квадрат


// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// //Математический путь
// int sqr = number * number;
// Console.WriteLine("Вывод математическим методом: ");
// Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

// //С помощью библиотеки
// int sqr1 = Convert.ToInt32(Math.Pow(number,2));
// Console.WriteLine("Вывод с помощью библиотеки: ");
// Console.WriteLine($"Квадрат числа {number} равен = {sqr1}");

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// int sqr = number2 * number2;
// if (sqr == number1)
// {
//     Console.WriteLine("Да, первое число квадрат второго числа");
// }
// else
// {
//    Console.WriteLine("Нет, первое число не квадрат второго числа"); 
// }

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Введи целое число: ");
// int number = int.Parse(Console.ReadLine());
// int a = -number;
// while (a <= number)
// {
//     Console.WriteLine(a);
//     a += 1;
// }

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.Write("Введите число от 1 до 7: ");
// int n = int.Parse(Console.ReadLine());
// if (n == 1)
// {
//     Console.Write("Понедельник");
// }
// if (n == 2)
// {
//     Console.Write("Вторник");
// }
// if (n == 3)
// {
//     Console.Write("Среда");
// }
// if (n == 4)
// {
//     Console.Write("Четверг");
// }
// if (n == 5)
// {
//     Console.Write("Пятница");
// }
// if (n == 6)
// {
//     Console.Write("Суббота");
// }
// if (n == 7)
// {
//     Console.Write("Воскресенье");
// }

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("Введите 3-x значное число: ");
// int n = int.Parse(Console.ReadLine());
// int a = n % 10;
// Console.Write(a);



//ДОМАШНЕЕ ЗАДАНИЕ ПО ПЕРВОМУ СЕМИНАРУ!


// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine($"max = {number1}");
// }
// else
// {
//     Console.WriteLine($"max = {number2}");
// }




// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()); 
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = int.Parse(Console.ReadLine());
// int max = number1;
// if (number2 > max) max = number2;
// if (number3 > max) max = number3;
// Console.Write($"Максимальное число: {max}");




// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());
// int div = number % 2;
// if (div == 0)
// {
//     Console.Write("Это чётное число!");
// }
// else
// {
//     Console.Write("Это нечётное число!");
// }



// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите целое число: ");
// int N = int.Parse(Console.ReadLine());
// int A = 1;
// while (A <= N)
// {
//     int div = A % 2;
//     if (div == 0)
//     {
//         Console.WriteLine(A);
//     }
//     A += 1;
// }













