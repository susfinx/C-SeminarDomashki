/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int [,] GetgeneratedArray (int size)
{
    
    int[,] generatedArray = new int[size, size];
    int i = 0;
    int j = 0;
    generatedArray [0,0]=1;
    for (int step=2; step <= size*size; step++)
    {
        if (i <= j + 1 && i + j < generatedArray.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= generatedArray.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > generatedArray.GetLength(1) - 1)
        j--;
        else
        i--;
        generatedArray[i, j] = step;
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

}

int [,] generatedArray=GetgeneratedArray (4);
showArray (generatedArray);
