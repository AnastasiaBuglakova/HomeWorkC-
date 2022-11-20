//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue){
    double[,] array = new double[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = Math.Round((new Random().Next(minValue, maxValue+1) + new Random().NextDouble()),1);      
        }
    }
    return array;
}
void Show2dArray(double[,] array){
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue){
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array){
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
void FindPositionInArray(int row, int column, int[,] array)
{
    if((row > (array.GetLength(0))-1) || (column > (array.GetLength(1)-1))) 
        Console.WriteLine("числа с такими индексами в массиве нет");
    else Console.WriteLine("Значение указанного элемента: " + array[row, column]);
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine("Input a row of position:");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a column of position:");
int c = Convert.ToInt32(Console.ReadLine());
FindPositionInArray(r, c, myArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue){
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array){
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
void ArithmeticalMeanInColumn(int[,] array)
{
    Console.WriteLine("Arithmetical Mean of Columns");
        for(int j = 0; j< array.GetLength(1); j++)
        {
            double arithmeticalMean = 0;
            for(int i = 0; i< array.GetLength(0); i++)
            {
                arithmeticalMean += array[i, j];
            }
            Console.Write(Math.Round((arithmeticalMean / array.GetLength(0)), 1)+ " ");
    }
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
ArithmeticalMeanInColumn(myArray);
