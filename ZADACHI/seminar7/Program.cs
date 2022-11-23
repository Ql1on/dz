/*
void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
*/

/*
// Задайте двумернintсив размером m×n, заполненный случайными вещественными числами.
void Show2dArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]/10 + " ");
        }
        Console.WriteLine();
    }
}

double[,] Create2dArray (int m, int n)
{
    
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++){
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100));
        }
    return array;
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");


double[,] someArray = Create2dArray(m,n);
Show2dArray(someArray);
*/


/*
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void FindElementIn2dArray (int[,] array)
{
    Console.Write("Введите строку ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колонну ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < array.GetLength(0) && j < array.GetLength(1)) 
        Console.Write(array[i,j] + $"-число на позиции [{i},{j}]");
    else Console.WriteLine("ERROR");
}

int[,] CreateRandom2dArray (int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next( min, max + 1);
        }
    }
    return array;
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int maxValue = Convert.ToInt32(Console.ReadLine());
/*
int[,] someArray = CreateRandom2dArray(m,n,minValue,maxValue);
Show2dArray(someArray);
FindElementIn2dArray(someArray);
*/
/*
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void ShowArray (double[] array) {
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++){
        Console.Write("[" + Math.Round(array[i],2) + "] ");
    }
}

double[] Average2dArray (int[,] array2d){
    double[] array = new double[array2d.GetLength(1)];
    for (int j = 0; j < array2d.GetLength(1); j ++) {
        double sum = 0;
        double count = 0;
        for (int i = 0; i < array2d.GetLength(0); i++ )
        {
            sum += array2d[i,j];    
            count++;        
        }
    array[j] = sum/count;
    }
    return array;
}
int[,] CreateRandom2dArray (int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next( min, max + 1);
        }
    }
    return array;
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] someArray = CreateRandom2dArray(m,n,minValue,maxValue);
Show2dArray(someArray);
double[] myArray = Average2dArray(someArray);
ShowArray(myArray);
*/