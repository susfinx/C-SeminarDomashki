/*адача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
Console.WriteLine("Hello, World!");
*/

int getuserNumber ()

{
    int result = 0;
    
    while (result == 0 || Math.Abs(result)< 10)
    {
    
        string Userline = Console.ReadLine();
        int.TryParse(Userline, out result);

        if (result == 0)
        {
            Console.WriteLine ($"Vy Vveli {Userline} eto ne coreknoe chislo");
        }

        else if (Math.Abs(result)< 10)
        {
            Console.WriteLine ($"Modul chisla {Userline} nepodhodit, neobhodimo kak minimum dvuh znachnoe chislo");

        } 

      
       
    }
    return Math.Abs(result);
    
}


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

Console.WriteLine(" Vvedite NE Odnoznachnoe chislo");
int Chislo = getuserNumber ();
int SumDigit = getSumDigit ( Chislo );
Console.WriteLine(SumDigit);
