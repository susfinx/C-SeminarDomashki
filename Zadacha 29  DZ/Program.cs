/* Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .

5 -> [1, 2, 5, 7, 19]

3 -> [6, 1, 33] */

void printeArray(int[]array)
{
    Console.Write("[");
    for (int i =0;i<array.Length;i++) 
    {
        Console.Write(array[i]);
        if (i <array.Length -1);
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}




Console.WriteLine("Zadayte dlinnu massiva!");
int DlnnaMassiva = Convert.ToInt32(Console.ReadLine());
int [] array = new int [DlnnaMassiva];
for (int i =0;i<array.Length;i++)
{
    array[i]= new Random().Next(1,100);
}

printeArray (array);