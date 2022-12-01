/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int Number = new Random().Next(456, 918);
int NewNumber = 0;
Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());

int NumberShowSecondDigital()

{
    NewNumber = (Number % 100) / 10;
    return NewNumber;
}

NumberShowSecondDigital();

Console.Write("Показать вторую цифру трехзначного числа");
Console.Write(NewNumber);
