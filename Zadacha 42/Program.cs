/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
int getUserNumber (string userInformation)    // Poluchenie chisla ot Usera
{
    int result;
    Console.WriteLine ("VVedite Chislo");
    while (!int.TryParse(Console.ReadLine(),out result)|| result <=0)
    {
        Console.WriteLine ("Oshibka vvoda ");
    }
    return result;
} 

int getLengthArray (int number)
{
    int count=0;
    while (number!=0)
    {
        number /= 2;
        count++;
    }
    return count;
}

bool [] getBoolArray (int number)           // Convertaciya v dvoichnyi cod
{
    int length = getLengthArray (number);
    bool[]boolArray = new bool [length];
    for (int index =0; index <length; index++)
    {
        boolArray [length-1-index]=number%2!=0;
        number/=2;
    }
    return boolArray;
}

void printboolarray (bool[] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.Write (array[i]?"1":"0");
    }
    Console.WriteLine();
}

int number = getUserNumber ("Vvedite Chislo");
bool [] boolArray = getBoolArray (number);
printboolarray (boolArray);