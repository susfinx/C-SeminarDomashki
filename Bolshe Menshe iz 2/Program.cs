// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Vvedite Chislo");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite Vtoroe Chislo");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) Console.Write($"Max {number1} Min {number2}");
else if (number1 < number2) Console.Write($"Max {number2} Min {number1}");
else if (number1 == number2) Console.Write("chisla ravny");