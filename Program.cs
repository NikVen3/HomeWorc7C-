//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resMatrix = GetMatrix (rows, columns, 0, 10);

PrintMatrix(resMatrix); 

double[,] GetMatrix(int m, int n,) 
{
    double[,] matrix = new Double[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(10, 100)), 2);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}    

*/


//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию строки: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] resMatrix = GetMatrix(rows, columns, 0, 10);

PrintMatrix(resMatrix); 

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}




void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
{
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

if (rows2 > resMatrix.GetLength(0) || columns2 > resMatrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
   Console.WriteLine($"значение элемента {rows2} строки и {columns2} столбца равно {resMatrix[rows2-1,columns2-1]}");
}

*/

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = GetMatrix(rows, columns, 0, 10);

PrintMatrix(resMatrix); 

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

for (int j = 0; j < resMatrix.GetLength(1); j++)
{
    int avarage = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        avarage = avarage + resMatrix[i,j];
    }
    avarage = avarage / rows;
    Console.WriteLine (avarage +"; ");
}


