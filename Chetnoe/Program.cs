// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Vvedite Celoe Chislo");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
if ( result > 0 ) Console.WriteLine("NET");
else Console.WriteLine("DA");