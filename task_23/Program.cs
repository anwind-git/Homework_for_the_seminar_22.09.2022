//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
    Console.WriteLine($"Куб числа {i}: {i} * {i} * {i} = {i * i * i}");
    i++;
}