// Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

string getdiapazanchetverti (int Chetvert)
{
    string  diapazon = "";
    if (Chetvert == 1)
    {
        diapazon = "x+ : y+";
    }
    else if ( Chetvert ==2)
    {
        diapazon = "x- : y+";
    }   
    else if ( Chetvert == 3)
    {
        diapazon = "x- : y-";
    }
    else if (Chetvert == 4)
    {
        diapazon = "x+ : y-";
    }
    return diapazon;

}

int proverkanaduraka  ()
{
    int result = 0;

    while (result == 0 || result > 4)
    {
    
        string Userline = Console.ReadLine();
        int.TryParse(Userline, out result);
        if (result == 0)
        {
            Console.WriteLine ($"Vy Vveli {Userline} eto ne celoe chislo");
        }
        else if (result > 4 || result< 0)
        {
            Console.WriteLine ($"chislo {Userline} nelzya predstavit v vide chetvrti Vvedite chislo ot 0 do +4" );
        }
    
    }
    return result;
}

int Chetvert = 0;
string Otvet = "";
Console.WriteLine("Vvedite Chetvert");
Chetvert = proverkanaduraka ();
Otvet = getdiapazanchetverti (Chetvert);

Console.WriteLine (Otvet);

