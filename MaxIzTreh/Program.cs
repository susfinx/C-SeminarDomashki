// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Vvedite Chislo");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite Vtoroe Chislo");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite Tretye Chislo");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2) max = num2;
else if (max < 3 ) max = num3;
Console.WriteLine($"Max {max}");
