/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
Console.WriteLine ("VVedite Chislo");
int userNumberOne= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("VVedite Chislo");
int userNumberTwo= Convert.ToInt32(Console.ReadLine());

int Stepen = Convert.ToInt32(Math.Pow(userNumberOne, userNumberTwo));
int umnojaemoe = userNumberOne;
VozvedenieVstepen (userNumberOne,umnojaemoe,Stepen);


void VozvedenieVstepen (int userNumberOne, int umnojaemoe, int Stepen)
{
    if ( umnojaemoe == Stepen)
    {
        return;
    }
    umnojaemoe*=userNumberOne;
    VozvedenieVstepen (userNumberOne,umnojaemoe, Stepen);
    Console.Write($"{umnojaemoe}, ");
}    