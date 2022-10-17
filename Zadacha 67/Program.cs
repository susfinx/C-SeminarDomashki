/* 
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
Console.WriteLine ("VVedite Chislo");
int userNumber= Convert.ToInt32(Console.ReadLine());
int sum=0;
int sumdig = GetSummdigit (userNumber);
Console.WriteLine(sumdig);
int GetSummdigit (int userNumber)
{   
    if(userNumber==0)
    {
        return sum;
    }
    sum+=userNumber%10;
    GetSummdigit (userNumber/10);
    return sum;
}
