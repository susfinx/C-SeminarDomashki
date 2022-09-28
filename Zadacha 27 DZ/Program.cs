/*адача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
Console.WriteLine("Hello, World!");


int getuserNumber (int UserNumber)
{
    int result= 0;
    
    while ( UserNumber < 10)
    {
         Console.WriteLine ($"VVedite celoe chislo bolshe 9, Vy vveli nekoreknoe chislo");
         break;
    }
    
    return result;
    
} */

int getSumDigit (int Chislo )
{
    int result = 0;
    int delimoe = Chislo;
    
    for (int i = 0; delimoe > 0; i++)
    {
        result = result + delimoe % 10;
        delimoe = delimoe/10;
        
    }
    return result;
}

Console.WriteLine(" Vvedite Chislo Bolee 9");
int Chislo = Convert.ToInt32(Console.ReadLine());
int SumDigit = getSumDigit ( Chislo );
Console.WriteLine(SumDigit);
