//Задача 45: Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.

int[] getRandomArray (int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i]= new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;
}

int[]getsecondArray ( int [] firstArray)
{
    int [] secondArray = new int [firstArray.Length];
    for (int i = 0; i<firstArray.Length; i++)
    {
        secondArray[i]=firstArray[i];
    }
    return secondArray;
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

int [] firstArray = getRandomArray (10, 5, 12);
printArray (firstArray);
int [] secondArray = getsecondArray (firstArray);
printArray (firstArray);