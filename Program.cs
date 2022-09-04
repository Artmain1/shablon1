// Написать программу возведения числа А в целую стень B



Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа: {Sum(number)}");

int Sum(int num)
{
    if (number == 1 || number1 == 0) return;
    return number * number Sum();
}
Console.WriteLine($"Сумма цифр числа: {Sum(number)}");




