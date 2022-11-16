//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int[] CreateCustomArray(int sizeOfArray){
    int[] customArray = new int[sizeOfArray];
    for(int i = 0; i < sizeOfArray; i++){
        Console.WriteLine($"Please, enter number #{i+1} of array:");
        customArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return customArray;
}

int СountPositiveNumbers(int[] customArr){
    int count = 0;
    for(int i = 0; i < customArr.Length; i++){
        if(customArr[i] > 0) count++;
    }
return count;
}
Console.WriteLine($"Please, enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int posCount = СountPositiveNumbers(CreateCustomArray(size));
Console.WriteLine(posCount);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCrossingPoint(double k1, double b1, double k2, double b2)
{
    if (k1 != k2){
        double xCrossPoint = (b2 - b1) / (k1 - k2);
        double yCrossPoint = k1 * xCrossPoint + b1;
        Console.WriteLine("(" + xCrossPoint + "; " + yCrossPoint + ")");
    }
    else 
        Console.Write("These right lines don't have point of crossing");
}

Console.WriteLine($"Please, enter k1 for first right line :");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please, enter b1 for first right line :");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please, enter k2 for second right line :");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please, enter b2 for second right line :");
double b2 = Convert.ToInt32(Console.ReadLine());
FindCrossingPoint(k1, b1, k2, b2);