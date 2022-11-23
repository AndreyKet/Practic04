// //Вид 1

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// //Вид 2

// void Method2(string msg);
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);

// //Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //Вид 4
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = c + result;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "zz");
// Console.WriteLine(res);


// // Цикл FOR

// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine(i);
// }
// string Method4(int count, string c)
// {     
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = c + result;
//     }
//     return result;
// }
// string res = Method4(10, "zz");
// Console.WriteLine(res);

// //Цикл в цикле

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; i++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s = "qwerty"
// //            [0123..]
// // s[3] // r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }    
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();


// int[] arr = {1,5,2,3,2,6,4,7,7};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
    
// }
// void ReversArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int reversArr = i;
        
//         int sum = array[array.Length -1 -i];
//         array[array.Length -1 -i] = array[reversArr];
//         array[reversArr] = sum;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// ReversArray(arr);

// PrintArray(arr);







//Шпаргалка:
// Массивы - коллекция однотипных данных
// т.е. несколько значений одного типа данных
// массивы могут быть любого типа данных
// чтобы получить массив надо написать: тип_данных[]

// Определение массива:
// со значением
// int[] array = new int[] { 1, 2, 3 }; // в массиве сразу будут значения [1, 2, 3]
// int[] array = { 1, 2, 3 }; // или так (без new тип_данных[])
// int[] array = { "один", "два", "три" }; // так не получится, нужен правильный тип данных
// string[] stringArray = new string[] { "один", "два", "три" }; // ["один", "два", "три"]

// с указанием размера
// int[] array = new int[3]; // размер 3, заполняется значением по умолчанию: [0, 0, 0]

// Индексы массива: 
// индекс - номер элемента в массиве. индексы начинаются с 0
// int[] array = { 1, 2, 3 };
// int x = array[0]; // первый по счёту элемент массива, индекс 0
// Console.WriteLine(x); // 1
// array[0] = 5; // изменение первого элемента (с индексом 0) с 1 на 5
// Console.WriteLine(array[0]); // 5

// Длина массива:
// длина массива - количество его элементов
// int[] array = { 1, 2, 3 };
// int x = array.Length; // получение количества элементов (длины)
// Console.WriteLine(x); // 3

// Перебор массива:
// int[] array = { 1, 2, 3 };
// // индексы начинаются с 0, поэтому и цикл с 0
// // условие строго меньше длины, потому что последний индекс на 1 меньше длины
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.WriteLine(array[i]); // Выведет 1, потом 2, потом 3
// }

// Строки - массивы букв
// string str = "Hello world";
// Console.WriteLine("Первый символ: " + str[0]); // выводим первый символ строки: буква H
// Console.WriteLine("Все символы строки в стоблик: ");
// for (int i = 0; i < str.Length; i++) 
// {
//     Console.WriteLine(str[i]); // Выведет все символы в столбик
// }
// Отличие строки от массива:
// string str = "Hello world";
// str[0] = 'T'; // ошибка: элементы строки нельзя изменять

// Функции (или методы - это одно и то же): 
// Объявление функций:
// тип_данных название_функции(входные_параметры)

// Функция возвращающая результат:
// return - специальное ключевое слово. Оно возвращает результат, который записан после неё
// и останавливает выполнение функции
// int GetSquare(int number)
// {
//     int square = number * number; // получаем квадрат числа
//     return square; // возвращение результата и завершение функции
// }

// int x = GetSquare(5); // вызов функции
// Console.WriteLine(x); // 25


// Функция НЕ возвращающая результат:
// void - тип данных специально для функций, которые ничего не возвращают
// void PrintMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 2); // вызов функции

// Использование return для остановки функции
// void PrintMessage(string message, int number)
// {
//     if (number > 3)
//     {
//         Console.WriteLine("Слишком большой номер");
//         return; // если number > 3, то выводим сообщение и заканчиваем выполнение функции
//         // т.е. дальше выполнение кода не пойдёт
//     }
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 4); // вызов функции

// какая-то программа: считывает число с консоли и возвращает его квадрат
// Все функции лучше описывать в начале программы (сверху)
// int GetSquare(int number)
// {
//     return number * number;
// }

// string str = Console.ReadLine();
// int x = int.Parse(str);
// x = GetSquare(x);
// Console.WriteLine(x);


// Распространённая ошибка:
// Лишние действия 2 и 3: 
// 1. Читаем строку (string) с консоли - Console.ReadLine()
// 2. Переводим строку в число - int.Parse
// 3. Переводим число в строку - Convert.ToString
// Ошибка: если нам нужна только строка, то результат Console.ReadLine() не надо переводить в число
// int num = int.Parse(Console.ReadLine());
// string str = Convert.ToString(num); // число в строку

// Правильное решение:
// string str = Console.ReadLine();




// // Длина массива
// // Длина массива - колличество его элементов
// int[] array = { 0, 0, 0, 0, 0, 0, 0,};
// int x = array.Length; // получение количества элементов
// Console.WriteLine(x);


// //Перебор массива
// int[] array = { 0, 0, 0, 0, 0, 0, 0};
// //индекс начинается с 0, поэтому и цикл с 0
// // условие строго меньше длинны, потому что последний индекс на 1 меньше длины
// for ( int i = 0; i < array.Length; i++)
// {
// Console.WriteLine(array[i]);
// }

// // Строки - массивы букв
// string str = "Hello World!";
// Console.WriteLine(str[0]);

// for (int i = 0; i < str.Length; i++)
// {
//     Console.WriteLine(str[i]);
// }


//Функции:
//Обьявление функции:
//тип_данных название функции(входные параметры)

//Функция возвращающая результат:
// int getSquare(int number)
// {
//     int square =  number * number; //возвращает результат и завершает функцию
//     return square;
// }

// // int x = getSquare(5); // Вызов функции
// Console.WriteLine(getSquare(5)); // 25
// int y = getSquare(2);
// Console.WriteLine(y); // 4


//Функции не возвращающая результат
// void printMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     Console.WriteLine(message + " " + number); //
// }

// printMessage("Мое сообщение номер: ", 2); // Вызов функции

// // Использование return для остановки функции
// void printMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     if (number > 3)
//     {
//         Console.WriteLine("Слишком большой номер"); //
//         return;
//     }
//     Console.WriteLine(message + " " + number); //
// }

// printMessage("Мое сообщение номер: ", 2); // Вызов функции


// Распространенная оштбка
// int num = int.Parse(Console.ReadLine());
// string str = num.ToString();


// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// string str = Console.ReadLine();
// int num = int.Parse(str);
// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);




// Задача 2:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// string str = Console.ReadLine();
// int num = int.Parse(str);
// int sum = 1;
// for (int i = 1; i <= num; i++)
// {
//     sum *= i;
// }
// Console.WriteLine(sum);



// int Math (int number)
// {
//     int result = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         result *= i;
//     }
// return result;
// }

// Console.WriteLine("Введите число");
// string str = Console.ReadLine();
// int num  = int.Parse(str);

// Console.WriteLine(Math(num));


// Задача 3 (общая):
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     int x = new Random().Next(0, 2);
//     array[i] = x;
//     Console.WriteLine(array[i]);
// }
