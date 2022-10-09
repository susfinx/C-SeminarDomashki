/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
Console.WriteLine("Hello, World!");
*/
double [,] genered2DArray ( int hight, int winght, double randomStart, double randomEnd)
{
    double [,] twoDArray= new double [hight,winght];
    for (int i=0;i < hight;i++)
    {
        for (int j = 0; j< winght; j++)
        {
            twoDArray[i,j]=new Random().NextDouble();
        }
    }
    return twoDArray;
}
 void print2DArray (double[,] arrayToPrint)
{
    for (int i = 0; i< arrayToPrint.GetLength(0);i++)
    {
        for (int j = 0; j< arrayToPrint.GetLength(1);j++)
        {
            Console.Write(Math.Round(arrayToPrint[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }
}


double[,] arraydoubledigit = genered2DArray (5,5,-10,10);
print2DArray (arraydoubledigit);