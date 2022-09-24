// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
double FormulaDlinny(int firstTochkaX, int firstTochkaY, int firstTochkaZ, int secondTochkaX, int secondTochkaY, int secondTochkaZ)
{
    double result= Math.Sqrt(Math.Pow(firstTochkaX-secondTochkaX, 2) + Math.Pow(firstTochkaY-secondTochkaY, 2)+ Math.Pow(firstTochkaZ-secondTochkaZ, 2));
    return result;
} 


Console.WriteLine("vvedite X coordinat Pervoy tochki");
int firstTochkaX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Y coordinat Pervoy tochki");
int firstTochkaY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Z coordinat Pervoi tochki");
int firstTochkaZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("vvedite X coordinat vtoroy tochki");
int secondTochkaX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Y coordinat vtoroy tochki");
int secondTochkaY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite Z coordinat vtoroy tochki");
int secondTochkaZ = Convert.ToInt32(Console.ReadLine());


double Dlinnamejdutochkami = FormulaDlinny(firstTochkaX, firstTochkaY, firstTochkaZ, secondTochkaX,secondTochkaY,secondTochkaZ);
Console.WriteLine($"Rasstoyanie mejdu tochek {Dlinnamejdutochkami}");