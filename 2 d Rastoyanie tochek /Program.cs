//Задача 21: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

double FormulaDlinny(int firstTochkaX, int firstTochkaY, int secondTochkaX, int secondTochkaY)
{
    double result= Math.Sqrt(Math.Pow(firstTochkaX-secondTochkaX, 2) + Math.Pow(firstTochkaY-secondTochkaY, 2));
    return result;
} 


Console.WriteLine("vvedite X coordinat Pervoy tochki");
int firstTochkaX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Y coordinat Pervoy tochki");
int firstTochkaY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("vvedite X coordinat vtoroy tochki");
int secondTochkaX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Y coordinat vtoroy tochki");
int secondTochkaY = Convert.ToInt32(Console.ReadLine());
double Dlinnamejdutochkami = FormulaDlinny(firstTochkaX, firstTochkaY, secondTochkaX, secondTochkaY);
Console.WriteLine($"Rasstoyanie mejdu tochek {Dlinnamejdutochkami}");
