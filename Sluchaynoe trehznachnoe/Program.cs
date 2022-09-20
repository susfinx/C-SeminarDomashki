//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder +1);
    return result;
}
int randomnumber = getRandomNumberFromRange(100, 999);
int firstnumber = randomnumber/100;
int lastnumber = randomnumber%10;
int firstPlusLast = firstnumber*10+lastnumber;




Console.WriteLine($"Sluchaynoe Znachenie {randomnumber}");
Console.WriteLine (firstPlusLast);