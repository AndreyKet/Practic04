// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int number2 = int.Parse(Console.ReadLine());
// int i = 0;
// int sum = 1;
// while (i < number2)
// {
//     sum *= number1;
//     i++;
// }
// Console.Write("Вывод: " + sum);



Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int number2 = int.Parse(Console.ReadLine());
int sum = 1;
for (int i = 0; i < number2; i++)
{
    sum *= number1;
}
Console.Write("Вывод: " + sum);
