//Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
Console.WriteLine("VVedite Pervoe Chislo ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("VVedite Vtoroe Chislo ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if (result==0) Console.WriteLine("Da");
else  Console.WriteLine("Net");