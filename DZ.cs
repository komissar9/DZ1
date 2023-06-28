// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

// Console.Write("Введите первое число: ");
// double firstDigit = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double secondDigit = Convert.ToDouble(Console.ReadLine());
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine("Число " + firstDigit + " больше числа " + secondDigit);
// }
// else
// {
//     Console.WriteLine("Число " + secondDigit + " больше числа " + firstDigit);
// }
//4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

// Console.Write("Введите первое число: ");
// double firstDigit = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double secondDigit = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите третье число: ");
// double thirdDigit = Convert.ToDouble(Console.ReadLine());
// double max = firstDigit;
// if (max < secondDigit) max = secondDigit;
// if (max < thirdDigit) max = thirdDigit;
// Console.Write("Максимальное число: " + max);

//6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
// Console.Write("Введите число: ");
// double numberUser = Convert.ToDouble(Console.ReadLine());
// if (numberUser % 2 == 0)
//  {
//     Console.WriteLine("Число " + numberUser + " четное");
//  }
// else 
// {
//     Console.WriteLine("Число " + numberUser + " нечетное");
// }

//8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int evenDigit = 2;
Console.WriteLine("Все четные числа до " + numberUser + ":");
while (evenDigit < numberUser)
{
    Console.WriteLine(evenDigit);
    evenDigit += 2;
}