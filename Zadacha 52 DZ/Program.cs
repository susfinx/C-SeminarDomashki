/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] genered2DArray ( int hight, int winght, int randomStart, int randomEnd)
{
    int [,] twoDArray= new int [hight,winght];
    for (int i=0;i < hight;i++)
    {
        for (int j = 0; j< winght; j++)
        {
            twoDArray[i,j]=new Random().Next(randomStart, randomEnd+1);
        }
    }
    return twoDArray;
}

void print2DArray (int[,] arrayToPrint)
{
    for (int i = 0; i< arrayToPrint.GetLength(0);i++)
    {
        for (int j = 0; j< arrayToPrint.GetLength(1);j++)
        {
            Console.Write(arrayToPrint[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

double getsredneearifstolbcov (int [,]Array)
{
    double avg = 0;
    double sum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum += Array[i, j];
        }
        avg = sum / Array.GetLength(0);
        Console.Write(Math.Round(avg, 2) + "\t");
    }
    return avg;
}



int [,] Array = genered2DArray (3,3,-5,5);
print2DArray (Array);
Console.WriteLine ();
double srednee = getsredneearifstolbcov (Array);

