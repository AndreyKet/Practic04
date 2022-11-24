// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// // Вариант 1: Через WHILE

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// while (number > 0) 
// {
//     sum = sum + number % 10;
//     number /= 10;
// }

// Console.WriteLine(sum);



// // Вариант 2: Через FOR

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 0; number > 0; i++)
// {
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine(sum);


// int Amount(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10; 
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// string str = Console.ReadLine();
// int num  = int.Parse(str);

// Console.WriteLine(Amount(num));



// Такой еще вариант: ))

Console.Write("Введите число: ");
string arr = Console.ReadLine();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum = sum + (arr[i] - '0');
}    
Console.WriteLine(sum);
