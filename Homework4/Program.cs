/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
int FindPower(int a, int b){
    int res = 1;
    for(int i = 1; i <= b; i++){
        res = res * a;
    }
    return res;
}
Console.WriteLine("Please, enter digit A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter digit B:");
int b = Convert.ToInt32(Console.ReadLine());
int result = FindPower(a, b);
Console.WriteLine($" Result is {result}");
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*
int FindSumm(int num){
    int res = 0;
    for(int i = 0; i <= num; i++){
        res += i;
    }
    return res;
}
Console.WriteLine("Please, enter digit:");
int num = Convert.ToInt32(Console.ReadLine());
int result = FindSumm(num);
Console.WriteLine($" Result is {result}");*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void FillArray(int[] myArray){
    
    int le = myArray.Length;
    for(int index = 0; index < le; index++){
        myArray[index] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] myArray){
    
    int le = myArray.Length;
    for(int index = 0; index < le; index++){
        Console.Write(myArray[index] + " ");
    } 
}
int[] myArray = new int[8];
FillArray(myArray);
PrintArray(myArray);
