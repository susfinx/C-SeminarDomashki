/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
Console.WriteLine("Hello, World!"); */

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
    }Console.WriteLine("]");
    
} 


int getsumma (int [] PoluchiliMassiv)
{
    int SummaNechet =0;
    for ( int i = 0; i< PoluchiliMassiv.Length; i=i+2)
    {
        SummaNechet= SummaNechet+ PoluchiliMassiv[i];
    }
    return SummaNechet;
}   

int [] PoluchiliMassiv = getRandomArray (10, 0,100);
printArray (PoluchiliMassiv);
int SummaChiselNechetnyhPoz = getsumma (PoluchiliMassiv);
Console.WriteLine($"Summa nechetnyh Poziciy Massiva ravna {SummaChiselNechetnyhPoz}");