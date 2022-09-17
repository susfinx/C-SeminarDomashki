// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("VVedite Chislo");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;
while ( count <= num )
{
    Console.Write($"{count}, ");
    count++;
}
