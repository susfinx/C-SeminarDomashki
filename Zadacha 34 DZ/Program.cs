/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
Console.WriteLine("Hello, World!");*/


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
int ColichestvoChetnyhElementov (int[] PoluchiliMassiv)
{
    int result = 0;
    for (int i = 0; i < PoluchiliMassiv.Length; i++)
    {   
     
        if (PoluchiliMassiv[i] % 2==0)
        {
            Console.Write ($"{PoluchiliMassiv[i]}, ");
            result++;
        }
    }Console.WriteLine();
    return result;
}   

int [] PoluchiliMassiv = getRandomArray (10, 100, 1000);
printArray (PoluchiliMassiv);
int PoluchiliColichestvoChetnyh = ColichestvoChetnyhElementov (PoluchiliMassiv);
Console.WriteLine ($"Colichestvo Chetnyh Chisel - {PoluchiliColichestvoChetnyh}");
