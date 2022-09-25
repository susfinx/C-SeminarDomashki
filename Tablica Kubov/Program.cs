// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("VVedite Chislo");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number < 0 )
{
    Console.WriteLine("Vvedite celoe, Polojitelnoe chislo");
}
int Count = 0;
int ChislaDoN = 1;

while ( ChislaDoN <= Number )
{
        
    int qvadraty = Convert.ToInt32(Math.Pow(ChislaDoN, 3));


    Console.Write($"{qvadraty}, ");
    ChislaDoN++;
    Count++;
             
}