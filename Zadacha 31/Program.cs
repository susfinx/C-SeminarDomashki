/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
    }

}
int [] currentArray = getRandomArray(12,-9,9);
int getSumPositiv (int [] incomingArray)
{
    int result = 0;
    for (int i=0;i<incomingArray.Length; i++)
    {
        if (incomingArray[i]>0)
        {
            result += incomingArray [i];
        }
    }
    return result;
}
int getSumNegativ (int [] incomingArray)
{
    int result = 0;
    for (int i=0;i<incomingArray.Length; i++)
    {
        if (incomingArray[i]<0)
        {
            result+= incomingArray [i];
        }
    }
    return result;
}

printArray (currentArray);

int SummPositiv = getSumPositiv (currentArray);

int SumNegativ = getSumNegativ (currentArray);
Console.WriteLine ($" Max={SummPositiv}, Min={SumNegativ}");
