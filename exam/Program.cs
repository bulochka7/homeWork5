/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[]CreateArray()     
{
    Console.WriteLine("Введите количество эл-тов ");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] array=new int[n];
    for(int i = 0; i<array.Length;i++)
    {
        Console.WriteLine("Введите число ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}  

int SumRes(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
        if(array[i]>0)
            sum++;
    return sum;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] myArray=CreateArray();
int res=SumRes(myArray);
ShowArray(myArray);
Console.WriteLine(res);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*

void PointXY()
{
    Console.WriteLine("Введите k1 ");
    double k1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b1 ");
    double b1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2 ");
    double k2=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2 ");
    double b2=Convert.ToDouble(Console.ReadLine());

    double resX=(b2-b1)/(k1-k2);
    double resY=(k1*resX)+b1;
    Console.WriteLine($"Точка пересечения ({resX};{resY})");

}
PointXY();
*/