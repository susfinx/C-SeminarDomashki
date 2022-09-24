// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int proverkanaduraka ()
{
    int result = 0;

    while (result == 0 )
    {
    
        string Userline = Console.ReadLine();
        int.TryParse(Userline, out result);
        if (result == 0)
        {
            Console.WriteLine ($"Vy Vveli {Userline} eto ne coreknoe chislo");
        }
        
        
    
    }
    return result;
}

string ProverkaNaPolindrom (int Number)
{ 
    string Otvet = "";
    int num5 = Number % 10;
    int num4 = Number / 10 %10;
    int num3 = Number / 100 %10;
    int num2 = Number / 1000 %10;
    int num1 = Number / 10000 %10;
    if ( num5==num1 && num4==num2)
    {
        Otvet = $"Chislo {Number} Yavlyaetsya Polindromom";
    }
    else
    {
        Otvet = $"Chislo {Number} NE Yavlyaetsya Polindromom";
    } 
    return Otvet;
}




Console.WriteLine("VVedite Pyatiznachnoe chislo");
int Number = proverkanaduraka ();
string Otvet = ProverkaNaPolindrom (Number);
Console.WriteLine(Otvet);


