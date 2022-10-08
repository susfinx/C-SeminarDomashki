/* Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Hello, World!");
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

 int getSummDiagonal (int [,] generatedArray)
 {
    int SummDiagonal = 0;
    int Bound=Math.Min(generatedArray.GetLength(0),generatedArray.GetLength(1));
    for (int i =0;i< Bound;i++)
    {
        SummDiagonal+= generatedArray [i,igit];
    }
    return SummDiagonal;

 }

 int [,] generatedArray= genered2DArray ( 5,5,1,10);
 print2DArray (generatedArray);
 int SummDiagonal = getSummDiagonal (generatedArray);
 Console.WriteLine($"Summa elementov po glavnoy diagonali matricy ravna {SummDiagonal}");
