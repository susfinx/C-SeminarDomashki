// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Vvedite TREHznachnoe cislo");
int Chislo = Convert.ToInt32(Console.ReadLine());
if (Chislo < 100 || Chislo > 999) Console.WriteLine("Tretyey Cifry Net ili chislo Ne treh znacnoe");
else Console.WriteLine(Chislo % 10);

