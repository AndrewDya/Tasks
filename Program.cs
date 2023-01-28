//Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да; a = 2, b = 10 -> нет; a = 9, b = -3 -> да; a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x * x == y)
// {
// Console.Write("Первое число является квадратом второго");
// }
// else
// {
// Console.Write("Первое число НЕ является квадратом второго");
// }

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7. a = 2 b = 10 -> max = 10. a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > y)
// {
// Console.Write($"Max: {x}");
// }
// else if (x < y)
// {
// Console.Write($"Max: {y}");
// }
// else if (x == y)
// {
// Console.Write("Числа равны");
// }

// Задача 3: Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда  5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
// Console.Write("Понедельник");
// }
// else if (number == 2)
// {
// Console.Write("Вторник");
// }
// else if (number == 3)
// {
// Console.Write("Среда");
// }
// else if (number == 4)
// {
// Console.Write("Четверг");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> .7; 44 5 78 -> 78; 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = 0; 
// if (a > b)
// {
// max = a;
// }
// else if (b > a)
// {
// max = b;
// }
// if (c > max)
// {
// max = c;
// }
// Console.Write($"{max}");

// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4". 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число : ");
// int x = Convert.ToInt32(Console.ReadLine());
// int i = x * (-1);
// while (i <= x);
// {
//     Console.Write($"{i} ");
//     i++;
// }
// Не решена

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да  -3 -> нет  7 -> нет

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// a = a % 2;
// if (a == 0)
// {
//     Console.Write("Число чётное");
// }
// else
// {
// Console.Write("Число нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4   8 -> 2, 4, 6, 8

// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int b = 2;
// while (b <= N)
// {
//     Console.WriteLine($"{b}");
//     b = b + 2;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5;  782 -> 8; 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (N > 1000 || N < 100)
// {
//     Console.WriteLine("Число не трёхзначное");
// }
// else 
// {
//     a = N % 100; 
//     a = a / 10; 
//     Console.WriteLine($"Вторая цифра трёхзначного числа: {a}");
// }

// Задача 11: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8; 12-> 2; 85 -> 8

// int a = new Random().Next(10,100); 
// int b = 0; 
// int c = 0;
// b = a % 10; 
// c = a / 10; 
// Console.WriteLine($"{a}");
// if (b > c)
// {
// Console.WriteLine($"{b}");
// }
// else
// {
//     Console.WriteLine($"{c}");
// }

// Задача 12: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46; 782 -> 72; 918 -> 98

// Console.Write("Введите трёхзначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 100 && N < 1000)
// {int a = 0;
// int b = 0; 
// int c = 0;
// a = N / 100; //6
// b = N % 100; //53
// b = b / 10; //5
// c = N % 10; //3
// Console.Write($"{a}");
// Console.Write($"{c}");
// }
// else 
// Console.Write("Число не трёхзначное");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// if (N < 100) 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if (N < 1000 && N > 100) 
// {
//     a = N % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 10000 && N > 1000) //6529
// {
//     a = N / 10;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 100000 && N > 10000) //65294
// {
//     a = N / 100;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }
// if (N < 1000000 && N > 100000) //652944
// {
//     a = N / 1000;
//     a = a % 10;
//     Console.WriteLine($"{a}");
// }

// Задача 14: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 ; 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// c = b % a;
// if (b % a == 0)
// {
//     Console.Write("Кратно");
// }
// else
// {
//  Console.Write($"Не кратно, остаток {c}"); 
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет

// Console.Write("Введите номер дня недели, чтобы узнать можно ли сегодня в кино: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
// Console.Write("Нет");
// }
// else if (number == 2)
// {
// Console.Write("Нет");
// }
// else if (number == 3)
// {
// Console.Write("Нет");
// }
// else if (number == 4)
// {
// Console.Write("Нет");
// }
// else if (number == 5)
// {
// Console.Write("Нет");
// }
// else if (number == 6)
// {
// Console.Write("Да");
// }
// else if (number == 7)
// {
// Console.Write("Да");
// }

// Задача 16: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет; 46 -> нет; 161 -> да

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 161 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0) 
// {
//     Console.WriteLine("Вы в четверти 1");
// }
// else if (x > 0 && y < 0) 
// {
//     Console.WriteLine("Вы в четверти 2");
// }
// else if (x < 0 && y < 0) 
// {
//     Console.WriteLine("Вы в четверти 3");
// }
// else if (x < 0 && y > 0) 
// {
//     Console.WriteLine("Вы в четверти 4");
// }

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

// Console.Write("Введите номер четверти: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1)
// {
//  Console.WriteLine("В диапазоне x > 0; y > 0");
// }
// else if (a == 2)
// {
//  Console.WriteLine("В диапазоне x > 0; y < 0");
// }
// else if (a == 3)
// {
//  Console.WriteLine("В диапазоне x < 0; y > 0");
// }
// else if (a == 4)
// {
//  Console.WriteLine("В диапазоне x < 0; y > 0");
// }
// else if (a < 1 || a > 4);
// {
//     Console.WriteLine("За пределами номера четверти");
// }

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int a1 = 0;
// int b = 0;
// int b1 = 0;
// a = N / 10000;
// a1 = N % 10;
// b = (N / 1000) % 10;
// b1 = (N / 10) % 10;
// if (N > 9999 && N < 100000 && a == a1 && b == b1) 
// {
//     Console.WriteLine("Палиндром");
// }
// else if (N < 10000 || N > 100000)
// {
//     Console.WriteLine("Прочтите условие внимательнее");
// }
// if (a != a1 || b != b1) 
// {
//     Console.WriteLine("Не палиндром");
// }

// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите x первой координаты: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y первой координаты: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x второй координаты: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y второй координаты: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// double c = Math.Sqrt((Math.Pow((a1-b1),2)) + Math.Pow((a2-b2),2));
// c = Math.Round(c,3);
// Console.WriteLine(c);

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите x первой координаты: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y первой координаты: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z первой координаты: ");
// int a3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x второй координаты: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y второй координаты: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z второй координаты: ");
// int b3 = Convert.ToInt32(Console.ReadLine());
// double c = Math.Pow((a1-b1),2) + Math.Pow((a2-b2),2) + Math.Pow((a3-b3),2);
// double d = Math.Sqrt(c);
// d = Math.Round(d,2);
// Console.WriteLine($"Расстояние между отрезками: {d}");

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28;  4 -> 10 8 -> 36

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// int i = 0;
// while (i <= a)
// {
//     sum = sum + i;
//     i++;
// }
// Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine()); 
// int deg = 1;
// int i = 0;
// while (i < b)
// {
//     deg = deg * a;
//     i++;
// }
// Console.WriteLine($"{a} в степени {b} = {deg}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// while (a > 0)
// {
//     a = a / 10;
//     sum = sum + 1;
// }
// Console.WriteLine($"Количество цифр в числе {sum}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int sum = 0;
// int b = 0;
// while (a > 0)
// {
//     b = a % 10;
//     sum = sum + b;
//     a = a / 10;
// }
// Console.WriteLine($"Сумма цифр в числе {sum}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int num = 1;
// int i = 1;
// while (i <= a)
// {
//     num = num * i;
//     i++;
// }
// Console.WriteLine($"Произведение чисел от 1 до {a} = {num}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

// int [] numbers = new int[8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 30);
//     Console.Write($"{numbers [i]}, ");
//  }
// Console.Write("]");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] numbers = new int[8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 2);
//     Console.Write($"{numbers [i]}, ");
//  }
// Console.Write("]");

// Теория 1 (Работа с Git)
// git remote add origin https://github.com/AndrewDya/Conspect.git - Команды для выгрузки на удалённый репозиторий с ПК
// git branch -M master
// git push -u origin master
// git clone https://github.com/AndrewDya/Conspect.git - склонировать внешний репозиторий на ПК
// git pull - скачать всё из удалённого репозитория и merge
// git init - инициализация локального репозитория
// git status - состояние git
// git add - добавить файлы к следующему коммиту
// git commit -m "message" - создание коммита
// git log - вывод на экран истории всех коммитов
// git checkout ... - переход от одного коммита к другому, переключиться
// git checkout master - вернуться к ветке master и продолжить
// git diff - увидеть разницу между текущим и закомиченным файлом
// git branch - просмотр веток
// git brach -d ... - удаление ветки
// git merge ... - объединение двух веток (слияние с основной)
// - Pull request:
// - Делаем fork репозитория
// - Делаем clone СВОЕЙ версии репозитория
// - Создаём новую ветку и в неё вносим свои изменения
// - Фиксируем изменения (делаем коммиты)
// - Отправляем свою версию в свой GitHub
// - На сайте GitHub нажимаем кнопку Pull request
// dotnet new console - создать новый проект
// dotnet run - запустить проект
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 

// Теория 2 (Операции)
// || Условный оператор ИЛИ (хотя бы одно из условий должно выполняться); && Условный оператор И (оба условия должны выполняться); ! логическое отрицание
// & оператор И (Оператор & вычисляет оба операнда); | оператор ИЛИ (Оператор | вычисляет оба операнда)
// int a = new Random().Next(1,3); генерация случайного числа от 1 до 3
// for (int i = 0; i < 10; i++) цикл с условием; где i++ инкримент эквивалентный i = i + 1
// Console.WtiteLine(Math.Abs(a)) модуль a
// Console.WtiteLine(Math.Round(a, 2)) округление a до 2 знаков после запятой
// Math.Sqrt(x); квадратный корень х
// Math.Pow(x, 3); возведение в х степень 3
// % отстаток от деления: Например 11 % 2 == 1

// Массивы
// string[] fact - массив строк название fact
// int[] numbers - массив числовой название numbers
// Console.WriteLine(f.Length) - вывести длину массива
// for (int i = 0; i < numbers.Length; i++)
// {Console.WriteLine(numbers.Length);}

// Методы; функции
// void SayLang()- метод (1) который ничего НЕ принимает, ничего НЕ возвращает
// метод (2) который принимает, но НЕ возвращает
// метод (3) который ничего НЕ принимает, но возвращает
// метод (4) который принимает и возвращает
