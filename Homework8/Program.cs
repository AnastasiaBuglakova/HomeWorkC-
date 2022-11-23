//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива. Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
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
void PutInOrderInRows(int[,] array)
{
    for(int i= 0; i< array.GetLength(0); i++)
    {
        for(int sortedSize = 0; sortedSize < array.GetLength(1); sortedSize++)
        {
            for(int j = 0; j< array.GetLength(1)-1-sortedSize; j++)
            {
                if(array[i,j] > array[i,j+1])
                {
                int t = array[i, j+1];
                array[i,j+1] = array[i,j];
                array[i,j] = t;
                }
            }
        }
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
PutInOrderInRows(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов. Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
*/
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int[,] FindSummInRows(int[,] array)
{
    int[,] rowArray = new int[array.GetLength(0), 1];
    
    for(int i= 0; i< array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j< array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        rowArray[i,0]= sum;
    }
    return rowArray;
}
int FindMinInArray(int[,] array)
{
    int minSum = array[0, 0];
    int minPos = 0;
        for(int i = 0; i< array.GetLength(0); i++)
        {
            if(array[i,0] < minSum) 
            {
                minSum = array[i,0];
                minPos = i;
            }
        }
    return minPos;
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
int[,] sumArray = FindSummInRows(myArray);
int res = FindMinInArray(sumArray);
Show2dArray(sumArray);
Console.WriteLine(res);
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
void CalculateProduct(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0),arrayB.GetLength(1)];
    if(arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        for(int i=0; i < arrayA.GetLength(0); i++)
        {
            for(int l=0; l < arrayB.GetLength(1); l++)
            {
            int prod = 0;
            for(int j=0; j < arrayA.GetLength(1); j++){
                prod += arrayA[i,j] *arrayB[j,l];
            }
            arrayC[i,l] = prod;
            Console.Write(prod + " ");
            }
        Console.WriteLine();
        }
    }
    else Console.WriteLine("Wrong size of arrays A & B (A number of columns for array A should be equal a number of columns for array B:");
}
Console.WriteLine("We are going to create array A:");
Console.WriteLine("Input a number of rows:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max1 = Convert.ToInt32(Console.ReadLine());
int[,] myArrayA = CreateRandom2dArray(m1,n1,min1,max1);
Show2dArray(myArrayA);
Console.WriteLine("We are going to create array B:");
Console.WriteLine("Input a number of rows:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myArrayB = CreateRandom2dArray(m2,n2,min2,max2);
Show2dArray(myArrayB);
Console.WriteLine();
CalculateProduct(myArrayA, myArrayB);
*/
 

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/*int[,,] CreateRandom3dArray(int rows, int columns, int layers, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, layers];
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                int temp = new Random().Next(minValue, maxValue+1);     
                for(int x = i-1; x > -1; x--)
                    {
                    for(int y = j-1; y > -1; y--)
                        {
                            for (int z = k-1; z > -1; z--)
                            {
                                if(temp == array[x,y,z]) temp = new Random().Next(minValue, maxValue+1);
                                else array[i,j,k] = temp;
                            }
                        }
                   }  
            }        
        }      
    }
    return array;
}*/
/*
int[,,] CreateRandom3dArray(int rows, int columns, int layers, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, layers];
    int[] numberArray = new int[maxValue - minValue + 1];
    for(int i = 0; i < (maxValue - minValue + 1); i++)
    {
        numberArray[i] = minValue + i;
    }
    for (int i = 0; i < (maxValue - minValue + 1); i++)
    {
        int iChange1 = new Random().Next(0, maxValue - minValue + 1);   
        int iChange2 = new Random().Next(0, maxValue - minValue + 1);
        int temp = numberArray[iChange1];
        numberArray[iChange1] = numberArray[iChange2];
        numberArray[iChange2] = temp;
    }
    for(int h = 0; h < maxValue - minValue + 1;h++)
    {
        Console.Write(numberArray[h] + " ");
    }
    Console.WriteLine();
    int x = 0;
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                array[i,j,k] = numberArray[x];
                x++;
            }        
        }      
    }
    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            for (int k = 0; k< array.GetLength(2); k++)
            {
                Console.Write("(" + i + "," +j  + ","+k  + ") " + array[i,j,k] + "  ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of layers:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
if(m * n * p < (max-min))
{
    int[,,] myArray = CreateRandom3dArray(m,n,p,min,max);
    Show3dArray(myArray);
}
else Console.WriteLine("value range is not enough for such sizes of array");
*/
/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] Create2dArray(int rows, int columns, int minValue)
{
    int[,] array = new int[rows, columns];
    int quantityOfNumbers = rows * columns;
    int numberOfCycles = 0;
    // Определяем сколько циклов = прямоугольников надо заполнить
    if(rows < columns) 
    {
        if(rows%2 == 0) numberOfCycles = rows / 2;
        else numberOfCycles = (rows + 1) / 2;
    }
    else 
    {
        if(columns%2 == 0) numberOfCycles = rows / 2;
        else numberOfCycles = (columns + 1) / 2;  
    } 
    // заводим цикл для каждого прямоугольника
    for(int y = 0; y < numberOfCycles && quantityOfNumbers > 0; y++)
    { 
        int i = y;
        int j = y;
        // 1 идем по часовой стрелке и заполняем первую линию вправо
        for(j = y; j < columns-y && quantityOfNumbers > 0; j++)
        {
            array[i,j] = minValue + rows * columns - quantityOfNumbers;
            quantityOfNumbers--;
        }
                // 2 идем по часовой стрелке и заполняем вторую линию вниз
        for(i = y+1; i < rows-y && quantityOfNumbers > 0; i++)
        {
            array[i,columns-y-1] = array[i-1,columns-y-1] + 1;
            quantityOfNumbers--;
        }
        // 3 идем по часовой стрелке и заполняем третью линию влево
        for(j = columns-y-2; j > y-1 && quantityOfNumbers > 0; j--)
        {
            array[rows-y-1,j] = array[rows-y-1,j+1] + 1;
            quantityOfNumbers--;
        }
        // 4 идем по часовой стрелке и заполняем четвертую линию вверх
        for(i = rows -2-y; i>y && quantityOfNumbers > 0; i--)
        {
            array[i,y] = array[i+1,y] + 1;
            quantityOfNumbers--;
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

Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2dArray(m,n,min);
Console.WriteLine();
Show2dArray(myArray);