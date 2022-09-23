//  принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string number2 = number1.ToString();
char[] revers = number2.ToCharArray();
Array.Reverse(revers);
int num = int.Parse(revers);

if (num == number1)
    Console.WriteLine($"Число: {number1} палиндром");
else
    Console.WriteLine($"Число: {number1} не является палиндромом");