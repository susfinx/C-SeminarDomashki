/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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

int [] reversArrey (int [] PervyiMassiv )
{
    int [] reverseArray = new int [PervyiMassiv.Length];
    for (int i=0;i<PervyiMassiv.Length;i++)
    {
        reverseArray[i]= PervyiMassiv[PervyiMassiv.Length - i - 1];
    }
    return reverseArray;
}

int [] PervyiMassiv = getRandomArray ( 10, 0, 99);
printArray (PervyiMassiv);
int [] ReverseArray = reversArrey (PervyiMassiv);
printArray (ReverseArray);
