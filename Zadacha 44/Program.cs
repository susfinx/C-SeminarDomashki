// See https://aka.ms/new-console-template for more information
/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
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

int [] FebonachiN (int numberN)
{
    int []fArray = new int[numberN];
    fArray[0]=0;
    fArray[1]=1;
    for (int i = 2;i<numberN;i++)
    {
        fArray[i]= fArray[i-1]+fArray[i-2];
    }
    return fArray;
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
int numberN = getUserNumber ("VVedite chislo");
int [] generfibonachi = FebonachiN (numberN);
printArray (generfibonachi);