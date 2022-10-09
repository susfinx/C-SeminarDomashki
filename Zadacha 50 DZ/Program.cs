/* Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
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

int getUserNumber (string userInformation)    // Poluchenie chisla ot Usera
{
    int result;
    Console.WriteLine ("VVedite Chislo");
    while (!int.TryParse(Console.ReadLine(),out result)|| result <0)
    {
        Console.WriteLine ("Oshibka vvoda ");
    }
    return result;
} 

void getPoiskElementa ( int [,] Array, int UserNumber)

{

    int count=0;
    for (int i =0;i< Array.GetLength(0);i++)
    {
        for (int j =0;j< Array.GetLength(1);j++)
        { 
            
            if (UserNumber==count)
            {
                Console.WriteLine ($"Element pod indeksom {UserNumber}, raven {Array [i,j]}");
            }
            count++;

        }   
        
    }
    if (UserNumber>count )
    {
        Console.WriteLine ($"Elementa pod indeksom {UserNumber}, Net v dannom Massive");
    }
    
}


int [,] Array = genered2DArray ( 5, 5, -10, 10);
print2DArray (Array);
int UserNumber = getUserNumber ("VVedite Chislo");
getPoiskElementa ( Array, UserNumber);
