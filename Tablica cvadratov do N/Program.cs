// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
//чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4


Console.WriteLine("VVedite Chislo");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number < 0 )
{
    Console.WriteLine("Vvedite celoe, Polojitelnoe chislo");
}
int Count = 0;
int ChislaDoN = 1;

while ( ChislaDoN < Number )
{
        
    int qvadraty = Convert.ToInt32(Math.Pow(ChislaDoN, 2));


    Console.Write($"{qvadraty}, ");
    ChislaDoN++;
    Count++;
             
}
