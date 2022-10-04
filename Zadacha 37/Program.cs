/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
Console.WriteLine("Hello, World!")*/

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

int[] secondArray (int [] PervyiMassiv)
{
    int [] ResulsecondArray = PervyiMassiv;
    int maxIndex = PervyiMassiv.Length-1;
    for ( int i = 0 ; i < PervyiMassiv.Length/2; i++)
    {
        
        int FirstIndex = PervyiMassiv [i];
        int secondIndex = PervyiMassiv[maxIndex-i];
        ResulsecondArray [i]= FirstIndex * secondIndex;
   
    }
    
    return ResulsecondArray;
}
int [] PervyiMassiv = getRandomArray ( 10, 1, 10);
printArray (PervyiMassiv);
int [] VtoroyMassiv = secondArray(PervyiMassiv);
printArray (VtoroyMassiv);