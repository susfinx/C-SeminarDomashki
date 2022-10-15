/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int [,] GetordinalArray (int [,] generatedArray)
{
    int [,] ordinalArray=generatedArray;
    int  boof = 0;
    for (int i = 0; i < ordinalArray.GetLength(0); i++)
    {
        for (int j = 0; j < ordinalArray.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < ordinalArray.GetLength(1) - 1; k++)
            {
                if (ordinalArray[i, k] < ordinalArray[i, k + 1])
                {
                    
                    boof = ordinalArray[i, k];
                    ordinalArray[i, k] = ordinalArray[i, k + 1];
                    ordinalArray[i, k + 1] = boof;
                }
            }
        }
    }
    return ordinalArray;
}

int [,] generatedArray = GetgeneratedArray (5,5,10);
showArray (generatedArray);
int [,] ordinalArray = GetordinalArray (generatedArray);
showArray (ordinalArray);