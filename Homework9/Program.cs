//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n>1) ShowNumbers(n-1);
    
}
ShowNumbers(5);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int ShowSumm(int numberM, int numberN)
{
   if(numberN > numberM) return numberM + ShowSumm(numberM+1, numberN);
   else return 0;
}

Console.WriteLine("Please, enter a number M:");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter a number N:");
int nNumber = Convert.ToInt32(Console.ReadLine());
if(mNumber<nNumber) Console.WriteLine(ShowSumm(mNumber,nNumber));
if(mNumber>nNumber) Console.WriteLine(ShowSumm(nNumber,mNumber));
*/
//Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int numberM, int numberN)
{
    if(numberM == 0) return numberN +1;
    if(numberM > 0 && numberN == 0) return Akkerman(numberM-1, 1);
    if(numberM > 0 && numberN > 0) return Akkerman(numberM-1, Akkerman(numberM,numberN-1));
    else return 0;
}
Console.WriteLine("Please, enter a number M:");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter a number N:");
int nNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(mNumber,nNumber));
