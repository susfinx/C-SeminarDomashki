/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
 int [,] genered2DArray ( int hight, int winght, int randomStart, int randomEnd)
 {
    int [,] twoDArray= new int [hight,winght];
    for (int i=0;i < hight;i++)
    {
        for (int j = 0; j< winght; j++)
        {
            twoDArray[i,j]=i+j;
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

 int [,] generatedArray= genered2DArray ( 7,5,1,100);
 print2DArray (generatedArray);