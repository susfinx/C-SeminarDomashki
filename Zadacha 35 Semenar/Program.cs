/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
Console.WriteLine("Hello, World!");
*/


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
int ColichestvoElementov (int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i]>10 && incomingArray[i]<99)
        {
            Console.Write ($"{incomingArray[i]}, ");
            result++;
        }
    }Console.WriteLine();
    return result;
}   

int [] PoluchiliMassiv = getRandomArray (123, 0, 300);
printArray (PoluchiliMassiv);
int PoluchiliColichestvo = ColichestvoElementov (PoluchiliMassiv);
Console.WriteLine ($"Colichestvo Chisel v intervale ot 10 do 99 - {PoluchiliColichestvo}");