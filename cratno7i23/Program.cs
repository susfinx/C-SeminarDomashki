// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Vvedite chislo!");
int Number = Convert.ToInt32(Console.ReadLine());

string CratnoLichislo (int Number)
{
    string Kratno = "";
    if ( Number % 7 == 0 && Number % 23 ==0 )
    {
        Kratno = "DA";
    } 
    else Kratno = "Net";
    return Kratno;
}
string result = CratnoLichislo (Number);
Console.WriteLine(result);