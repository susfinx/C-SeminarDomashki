// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Vvedite Celoe Chislo");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < num)
{
    int chet = count % 2;
    if (chet==0) Console.Write($"{count}, ");
    count++;
}

