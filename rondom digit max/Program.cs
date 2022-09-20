// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder +1);
    return result;
}
int getMaxDigitFromNumber (int number)
{   
    int maxDigit = 0;
    while (number>0)
    {
        int currentDigit = number %10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
    }
    return maxDigit;
}
int randomNumber = getRandomNumberFromRange(109,5999);
Console.WriteLine($"Sluchaynoe Znachenie {randomNumber}");
int maxDigit = getMaxDigitFromNumber(randomNumber);
Console.WriteLine($"Dlya chisla {randomNumber} bolshaya cifra {maxDigit}");



