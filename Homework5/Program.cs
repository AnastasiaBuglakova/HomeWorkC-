//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] FillArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int FindSummOfEven(int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
            if(array[i] % 2 == 0) sum += array[i];
    }
    return sum;
}
Console.WriteLine("Please, enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = FillArray(size);
PrintArray(newArray);
int res = FindSummOfEven(newArray);
Console.WriteLine(res);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] FillArray(int size, int minArray, int maxArray){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minArray, maxArray);
    return array;
}
void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");
    Console.WriteLine();
}
int FindSumm(int[] arr){
    int sum = 0;
    for(int i = 1; i < arr.Length; i =i+2) sum += arr[i];
    return sum;
}
Console.WriteLine("Please, enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter min of array:");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter max of array:");
int maxArray = Convert.ToInt32(Console.ReadLine());
int[] newArray = FillArray(size, minArray, maxArray);
PrintArray(newArray);
int res = FindSumm(newArray);
Console.WriteLine(res);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] FillArray(int size, int minArray, int maxArray){
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minArray, maxArray) + new Random().NextDouble();
    return array;
}
void PrintArray(double[] arr){
    for(int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");
    Console.WriteLine();
}   
double FindDelta(double[] arr){
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
        if(arr[i] < min) min = arr[i];
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
        if(arr[i] > max) max = arr[i];
    double delta = max - min;
    return delta;
}
Console.WriteLine("Please, enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter min of array:");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter max of array:");
int maxArray = Convert.ToInt32(Console.ReadLine());
double[] newArray = FillArray(size, minArray, maxArray);
PrintArray(newArray);
double res = FindDelta(newArray);
Console.WriteLine(res);
