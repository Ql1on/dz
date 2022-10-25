
/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool PalindromCheck (int num) 
{
    int help = 0;
    int result = 0;
    int i = 0;
    int help2 = num;
    while (i < 5)
    {
        help = help2 % 10;
        help2 = help2 / 10;
        result = (result + help) * 10;
        i++;
    }
    result = result / 10;


    Console.WriteLine($"result{result}");
    Console.WriteLine($"num {num}");
    if (num == result) return true;
    else return false;

}
int a = Convert.ToInt32(Console.ReadLine());
bool r = PalindromCheck(a);
Console.WriteLine(r);
*/


/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void DistanceIn3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
    Console.WriteLine($"Расстояние между точками в 3D: {distance}");
}

Console.WriteLine("Введите три координаты первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите три координаты второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
DistanceIn3D(x1,y1,z1,x2,y2,z2);
*/

/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void QuadNumb (int N)
{
    double quad = 0;
    int i = 0;
    while (i < N)
    {
        i++;
        quad = Math.Pow(i,2);
        Console.WriteLine(quad);


    }

}
int num = Convert.ToInt32(Console.ReadLine());
QuadNumb(num);
*/