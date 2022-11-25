/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = ReadInt ("Введите число: ");

int temp = number;
int a = 0;
while (temp > 0)
{
    temp = temp/10;
    a++;
}
a = a - 1;
int sum = number%10;
while (a > 0)
{
    number = number/10;
    sum = sum + number % 10;
    a = a - 1;
}
Console.Write (sum);
int ReadInt (string messege)
{   
    Console.Write (messege);
    return Convert.ToInt32 (Console.ReadLine());
}