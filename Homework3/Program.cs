/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет, 12821 -> да, 23432 -> да*/
/*
bool CheckPalindrome(int num)
{
    int num1 = num % 10, num2 = (num / 10) % 10, num3 = (num / 100) % 10,
        num4 = (num / 1000) % 10, num5 = num / 10000;
    bool res = false;
    if(num1 == num5 || num2 == num4) res = true;
    else res = false;
    return res;
}

Console.WriteLine("Please, enter five-place number:");
int number = Convert.ToInt32(Console.ReadLine());
bool result = CheckPalindrome(number);
if(result == true) Console.WriteLine("This number is palindrome.");
else Console.WriteLine("This number isn't palindrome.");
*/

/* **Задача 21**
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84            A (7,-5, 0); B (1,-1,9) -> 11.53 */
/*
double ComputeDistanse3D(double x1, double  x2, double y1, double y2, double z1, double z2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)), 2);
    return dist;
}
Console.WriteLine("Please, enter x1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, enter y1:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, enter z1:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, enter x2:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, enter y2:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, enter z2:");
double z2 = double.Parse(Console.ReadLine());
double result = ComputeDistanse3D(x1, x2, y1, y2, z1, z2);
Console.WriteLine("3D distanse is " + result);
*/




/***Задача 23**
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27               5 -> 1, 8, 27, 64, 125*/
void Kub(double num)
{
    int i = 1;
    while (i - 1 < num)
    {
        Console.WriteLine(i + " " + i * i * i);
        i++;
    }
}
Console.WriteLine("Please, enter number:");
int num = Convert.ToInt32(Console.ReadLine());
Kub(num);