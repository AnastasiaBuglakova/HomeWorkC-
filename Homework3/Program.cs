/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет, 12821 -> да, 23432 -> да*/
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


/* **Задача 21**

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

**Задача 23**

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
