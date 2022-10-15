/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] GetMultipliedmatrix (int [,] generatedArrayOne, int [,]generatedArrayTwo)
{
    int [,] multipliedmatrix = generatedArrayOne;
    for (int i = 0; i < multipliedmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedmatrix.GetLength(1); j++)
        {
            int sum =0;
            for (int k = 0; k < generatedArrayOne.GetLength(1); k++)
            {
                sum+= generatedArrayOne[i,k]*generatedArrayTwo[k,i];
            }
            multipliedmatrix [i,j]=sum;

        }
    }
    return multipliedmatrix;
}

int [,] generatedArrayOne=GetgeneratedArray(4,4,5);
showArray (generatedArrayOne);
int [,] generatedArrayTwo=GetgeneratedArray(4,4,5);
showArray (generatedArrayTwo);
int [,] multipliedmatrix=GetMultipliedmatrix (generatedArrayOne, generatedArrayTwo);
showArray (multipliedmatrix);