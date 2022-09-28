/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetStepenChisla (int UserNumberA, int UserNumberB)
{
    int result=UserNumberA;

    for (int i = 1; i < UserNumberB; i++)
    {
       result = result * UserNumberA;
    }

    return result;
}

Console.WriteLine("Vvedite chislo A");
int UserNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo B");
int UserNumberB = Convert.ToInt32(Console.ReadLine());
int StepenBizA = GetStepenChisla (UserNumberA, UserNumberB);
Console.WriteLine($"Otvet {StepenBizA}");
