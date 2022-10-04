/* Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76
Console.WriteLine("Hello, World!"); */

double [] getRandomArray (int length)
{
    double [] resultArray = new double [length];

    for (int i = 0; i < length; i++)
    {
        resultArray [i]= new Random().NextDouble();
    }
    return resultArray;
}

void printArray (double[] incomingArray)
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

double getRaznicaMaxMin (double [] PoluchiliMassiv)
{
    double result =0;
    double MaxDigit=PoluchiliMassiv[0];
    double MinDigit=PoluchiliMassiv[0];
    for (int i = 0; i< PoluchiliMassiv.Length; i++)
    {
        if (PoluchiliMassiv[i]<MinDigit)
        {
            MinDigit=PoluchiliMassiv[i];
    
        }
        if (MaxDigit<PoluchiliMassiv[i])
        {
            MaxDigit=PoluchiliMassiv[i];
        }
        result= MaxDigit-MinDigit;
    }
    Console.WriteLine ($" Max {MaxDigit}, Min {MinDigit}");
    return result;
}
double [] PoluchiliMassiv = getRandomArray(10);
printArray (PoluchiliMassiv);
double RaznicaMinMax=getRaznicaMaxMin (PoluchiliMassiv);
Console.WriteLine ($"Raznica Max,Min = {RaznicaMinMax}");