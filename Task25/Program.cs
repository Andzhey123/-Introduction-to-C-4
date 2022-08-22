// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// "Напишите ЦИКЛ" значит возводить в степень нужно циклом, а не методом Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exp (int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
Console.WriteLine("\n Задача 25");
Console.WriteLine();
Console.Write("Введите первое число:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine()!);
long result = Exp(number1, number2);
Console.WriteLine($"{number1} в степени {number2} = {result}");