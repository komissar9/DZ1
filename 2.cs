// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Введите первое число: ");
double firstDigit = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double secondDigit = Convert.ToDouble(Console.ReadLine());
if (firstDigit > secondDigit)
{
    Console.WriteLine("Число " + firstDigit + " больше числа " + secondDigit);
}
else
{
    Console.WriteLine("Число " + secondDigit + " больше числа " + firstDigit);
}