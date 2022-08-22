// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.WriteLine("\n Задача 27");
Console.WriteLine();
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int result = Sum(number1);
Console.WriteLine($"Cумма чисел {number1} = {result}");