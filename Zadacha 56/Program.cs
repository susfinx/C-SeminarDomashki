/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка
*/

int [,] GetgeneratedArray (int height, int weight, int deviation)
{
    int [,] generatedArray =new int [height, weight];
    for ( int i = 0; i < height;i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j]= new Random().Next(deviation);
        }
    }
    return generatedArray;
}
void printColorData (string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray (int[,] inputArray)

{
    printColorData($"  \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0;i<inputArray.GetLength(0);i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray [i,j]}\t");
        }
        Console.WriteLine();
        
    }
    Console.WriteLine();

}

int GetLineMinSum (int [,] generatedArray)
{
    int BofLinesum = int.MaxValue;
    int indexMinsum = 0;
    for (int i = 0; i < generatedArray.GetLength(0); i++)
    {
        int linesum = 0;
        for (int j = 0; j < generatedArray.GetLength(1); j++)
        {
            linesum += generatedArray[i, j];
        }
        if (linesum < BofLinesum)
        {
        BofLinesum = linesum;
        indexMinsum = i;
        }
    }
    return indexMinsum;
}


int [,] generatedArray=GetgeneratedArray(4,5,5);
showArray (generatedArray);
int resultLine = GetLineMinSum (generatedArray);
Console.WriteLine($"Stoka s minimalnoy summoy elementov ravna {resultLine}");
