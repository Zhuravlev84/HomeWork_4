/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int a = ReadOn("Введите первое число: ");
int b = ReadOn("Введите второе число: ");
int sum = 1;
for (int count = 1;count <= b; count++)
{
    sum = sum*a; 
}
Console.Write($"Ответ: {sum}");

int ReadOn (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}