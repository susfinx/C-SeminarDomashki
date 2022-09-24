// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int getquartercoordinate (int usercoordinatX, int usercoordinatY)

{
    int result = 0;
    if (usercoordinatX > 0 && usercoordinatY > 0)
    {
        result = 1;
    }
    else if (usercoordinatX< 0 && usercoordinatY > 0)
    {
        result = 2;
    }
    else if (usercoordinatX< 0 && usercoordinatY < 0)
    {
        result = 3;
    }
        else if (usercoordinatX > 0 && usercoordinatY < 0)
    {
        result = 4;
    }

    return result;
}

int getProverkaNaDuraka (string userinformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userinformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0" )
        {
            Console.WriteLine ($"VVedite celoe chislo, Vy Vveli {userLine} Eto ne celoe chislo");
        }

    } return result;
}
int usercoordinatX = 0;
int usercoordinatY = 0;

Console.WriteLine("VVedite Coordinaty");
usercoordinatX = getProverkaNaDuraka ("X: ");
usercoordinatY = getProverkaNaDuraka ("Y: ");

int quarter = getquartercoordinate (usercoordinatX, usercoordinatY);

Console.WriteLine($"Tochka s koordinatami {usercoordinatX} : {usercoordinatY} Nahoditsya v {quarter} ploskosti");
