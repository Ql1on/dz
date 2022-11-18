/* 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void AboveZero (int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i}-ое число массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    ShowArray(array);
    int count = 0;
    for (int i = 0; i < M; i ++)
    {
        if (array[i] > 0) count++ ;
    }
    Console.WriteLine($"В массиве {count} чисел больше нуля");
}
Console.Write("Введите кол-во чисел в вашем массиве ");
int a = Convert.ToInt32(Console.ReadLine());
AboveZero(a);
*/
/*
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
void TwoLines (int b1, int k1, int b2, int k2 )
{
    
    int x = (b2 - b1) / (k1 - k2);
    int y1 = k1 * x + b1;
    int y2 = k2 * x + b2;
    Console.WriteLine($"Общая точка двух прямых находится на ({x},{y1})");
    Console.Write($" ({x},{y2})");
    
}
Console.Write("Введите значение b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
TwoLines(b1,k1,b2,k2);
*/