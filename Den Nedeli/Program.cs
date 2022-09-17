// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("VVEDITE Chislo Ot 1 do 7");
int day = Convert.ToInt32(Console.ReadLine());
if ( day == 1 )
{
    Console.WriteLine("Monday");
}
if ( day == 2 )
{
    Console.WriteLine("Tuesday");
}
if ( day == 3 )
{
    Console.WriteLine("Wednesday");
}
if ( day == 4 )
{
    Console.WriteLine("Thursday");
}
if ( day == 5 )
{
    Console.WriteLine("Friday");
}
if ( day == 6 )
{
    Console.WriteLine("Saturday");
}
if ( day == 7 )
{
    Console.WriteLine("Sunday");
}
if ( day < 1 )
{
    Console.WriteLine("Nekorektnoe Chislo");
}
if ( day > 7 )
{
    Console.WriteLine("Nekorektnoe Chislo");
}