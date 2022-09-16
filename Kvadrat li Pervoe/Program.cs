// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("VVedite Pervoe Chislo");
int NumX  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("VVedite Vtoroe Chislo");
int NumY = Convert.ToInt32(Console.ReadLine());
int Kvadrat = (NumY * NumY);
if (Kvadrat == NumX)
{
    Console.WriteLine($"Chislo {NumX} Kvadrat Chisla {NumY}");
}
else
{
    Console.WriteLine($"Chislo {NumX} NE Kvadrat Chisla {NumY}");
}