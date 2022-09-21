// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("VVedite Chislo ot 1 do 7");
int day = Convert.ToInt32(Console.ReadLine());

string Vyhodnoiy (int day)
{
    string dayweek = "";
    if (day== 1) dayweek = "Monday";
    else if (day == 2) dayweek = "Tuesday";
    else if (day == 3) dayweek = "Wednesday";
    else if (day == 4) dayweek = "Thursday";
    else if (day == 5) dayweek = "Friday";
    else if (day == 6) dayweek = "Saturday-Vyhodnoy";
    else if (day == 7) dayweek = "Sunday-Vyhodnoy";
    else if (day > 7 && day < 1) dayweek = "Nekoreknoe chislo";

    return dayweek;
}

string result = Vyhodnoiy (day);
Console.WriteLine(result);