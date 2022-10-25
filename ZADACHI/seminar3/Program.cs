
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

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

