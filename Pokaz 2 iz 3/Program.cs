// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number = new Random().Next(100, 999+1);

int Pokaz2Chisla ( int Number)
{   
    int Pokaz = Number / 10 % 10;
    return Pokaz;
}
Console.WriteLine(Number);
int vtoraya = Pokaz2Chisla (Number);
Console.WriteLine(vtoraya);