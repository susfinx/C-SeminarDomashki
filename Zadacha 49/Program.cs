/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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

 int [,] getZamenaelementovChetnyhIndexov (int [,] generatedArray)
 {
    int [,] getZamenaelementovChetnyhIndexov = generatedArray;
    for (int i=1;i < getZamenaelementovChetnyhIndexov.GetLength(0);i+=2)
    {
        for (int j = 1; j< getZamenaelementovChetnyhIndexov.GetLength(1); j+=2)
        {
            getZamenaelementovChetnyhIndexov[i,j]= getZamenaelementovChetnyhIndexov[i,j]*getZamenaelementovChetnyhIndexov[i,j];
        }
        
    }
    return getZamenaelementovChetnyhIndexov;
 }

 int [,] generatedArray= genered2DArray (7,7,1,10);
 print2DArray (generatedArray);
 Console.WriteLine();
int [,] ZamenaelementovChetnyhIndexov = getZamenaelementovChetnyhIndexov (generatedArray);
 print2DArray (ZamenaelementovChetnyhIndexov);