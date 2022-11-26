/* Задача 29: Напишите программу, которая задаёт массив
 из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/

int N = ReadOn ("Введите число: ");
int [] Numbers  = new int [N];

int i = 0;
while (i < Numbers.Length)
{
Numbers[i] = new Random().Next(0,100);
i++;
}
Console.Write("[ ");
WriteArray(Numbers);
Console.Write("]");
void WriteArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}    
int ReadOn (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}