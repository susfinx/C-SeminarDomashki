/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
Console.WriteLine("Hello, World!");
*/
Console.WriteLine ("VVedite Chislo");
int userNumberOne= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("VVedite Chislo");
int userNumberTwo= Convert.ToInt32(Console.ReadLine());
int numberMax=Convert.ToInt32(Math.Max(userNumberOne, userNumberTwo));
int numberMin=Convert.ToInt32(Math.Min(userNumberOne, userNumberTwo));
int summ=numberMin;
printRange (numberMax,numberMin,summ);

void printRange (int numberMax,int numberMin,int summ)
{
    if ( numberMax == numberMin)
    {
        return ;
    }
    summ+=numberMax;
    printRange(numberMax-1,numberMin,summ);
    Console.Write($"{summ}, ");
}