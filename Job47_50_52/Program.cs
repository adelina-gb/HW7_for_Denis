void Zadacha47()
{
    /*
    Задайте двумерный массив размером m x n, заполненный случайными вещественными числами,
    округленными до одного знака.

    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
    */

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    double[,] array = new double[rows, columns];

    DoubleFillArray(array, rows, columns);
    DoublePrintArray(array, rows, columns);
}

void DoubleFillArray(double[,] array, int rows, int columns)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 101) * 0.1;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
}

void DoublePrintArray(double[,] array, int rows, int columns)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha50()
{
    /*
    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    и возвращает значение этого элемента или же указывает, что такого элемента нет.
    1 4 7 2
    5 9 2 3
    8 4 2 4

    17 - такого числа в массиве нет
    */

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    ElementPositions(array);
}
void FillArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ElementPositions(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    Console.WriteLine("Введите номер строки искомого элемента: ");
    int rowsIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента: ");
    int columnsIndex = Convert.ToInt32(Console.ReadLine());

    if(rowsIndex >= 1 && rowsIndex <= columns &&
       columnsIndex >= 1 && columnsIndex <= columns)
       {
        Console.WriteLine($"Искомое число с номерами строки и столбца ({rowsIndex},{columnsIndex}) - {array[rowsIndex-1, columnsIndex-1]}.");
       }
    else Console.WriteLine($"Искомого числа с номерами строки и столбца ({rowsIndex},{columnsIndex}) в массиве нет.");    
}


void Zadacha52()
{
    /*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    */


    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Average(array);
}

void Average(int[,] array)
{

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    
    for (int j = 0; j < columns; j++)
    {
        double result = 0;
        for (int i = 0; i < rows; i++)
        {
            result =result + array[i,j];    
        }
          
        Console.Write(result/rows + "\t");            
    }
    
}


//Zadacha47();
//Zadacha50();
Zadacha52();



