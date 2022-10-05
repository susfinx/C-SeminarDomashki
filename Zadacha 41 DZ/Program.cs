/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/

int getLengthArray (string userInformation)    // Poluchenie chisla ot Usera
{
    int result;
    Console.WriteLine ("VVedite Chislo dlinny massiva");
    while (!int.TryParse(Console.ReadLine(),out result)|| result ==0)
    {
        Console.WriteLine ("Oshibka vvoda ");
    }
    return result;
} 

int [] getArray (int LengthArray)
{
    int [] Array = new int [LengthArray];
    int count = 0; 
    int result;
    while (count < LengthArray)
    {
        Console.WriteLine ("Vvedite chislo dlya elementa massiva");
        while (!int.TryParse(Console.ReadLine(),out result))
        {
            Console.WriteLine ("Oshibka vvoda ");
        }
        Array[count]=result;
        count++;
    }
    return Array;

}

void printArray (int[] incomingArray)
{
    Console.Write ("[");
    for (int i = 0; i<incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i<incomingArray.Length -1)
        {
            Console.Write(",");
        }
    }Console.WriteLine("]");
}   

int getcountplus (int [] Array)
{
    int count =0;
    for (int i =0; i < Array.Length; i++)
    if (Array [i]>0)
    {
        count++;
    }
    return count;
}

int LengthArray = getLengthArray ("Vvedite Dlinnu Massiva");
int [] Array = getArray (LengthArray);
printArray (Array);
int countplus = getcountplus (Array);
Console.WriteLine($" V massive {countplus} polojitelnyh chisel");

