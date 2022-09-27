/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int getSumofRanch (int startPoint, int endPoint)
{
    int result = 0;
    for (int i = startPoint; i<= endPoint; i++)
    {
        result +=i;
    }


    return result;
}

Console.WriteLine("Vvedite Chislo");
int usernumber = Convert.ToInt32(Console.ReadLine());
int sumOfRange = getSumofRanch (1, usernumber);
Console.WriteLine($"Summa Chisel ot 1 do {usernumber} = {sumOfRange}");


