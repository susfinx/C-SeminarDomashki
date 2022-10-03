/* See https://aka.ms/new-console-template for more information

int[] getRandomArray (int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i]= new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;
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
    }Console.WriteLine();
    
}    

int PoiskChisla (int[] incomingArray)
{
    int Zadanoechislo = Convert.ToInt32(Console.ReadLine());
    int NaydenoeChislo = 0;
    int Count= 0;
    for (int i = 0; i<incomingArray.Length; i++)
    {
        if (i==Zadanoechislo )
        {
            NaydenoeChislo=Zadanoechislo;
            Console.WriteLine($"Chislo {NaydenoeChislo} naydeno v pozicii {Count}");
        }
        Count++;
           
    }
    return NaydenoeChislo;
}
int [] currentArray = getRandomArray(150,0,200);
printArray (currentArray);
Console.WriteLine("Vvedite Iskomoe Chislo!");
int NaydenoeChislo = PoiskChisla (currentArray);
if (NaydenoeChislo==0)
{
    Console.WriteLine("Vedenogo chisla net v Massive");
}
Console.WriteLine($"Chislo {NaydenoeChislo} naydeno"); */

int[] getRandomArray (int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i]= new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;
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
    }Console.WriteLine();
    
}    
bool PoiskChisla (int [] incomingArray, int number)
{
   for (int i = 0; i<incomingArray.Length; i++)
   {
        if (Math.Abs(incomingArray[i])==Math.Abs(number))
        {
            return true;
        }
   }
   return false;
}

int[] currentArray = getRandomArray (20,-9,20);
printArray (currentArray);
Console.WriteLine ("Vvedite Iskomoe Chislo");

int userNumber = Convert.ToInt32(Console.ReadLine());
bool IsNumberINArray = PoiskChisla (currentArray, userNumber);
Console.WriteLine ($"Element {userNumber} {((IsNumberINArray)?"Da":"Net")}");
