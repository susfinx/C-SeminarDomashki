/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Hello, World!");
*/
Console.WriteLine("Vvedite tochku b1");
double firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite tochku k1");
double secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite tochku b2");
double thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite tochku k2");
double fourthNumber = Convert.ToInt32(Console.ReadLine());

double boofX = fourthNumber - secondNumber;
double digitX = -thirdNumber + firstNumber;
double cordinatesX = digitX / boofX;

double cordinatesY = fourthNumber * cordinatesX + thirdNumber;
Console.WriteLine($"Tochka х = {Math.Round(cordinatesX,2)} у = {Math.Round(cordinatesY,2)}");

