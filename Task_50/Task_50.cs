// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] FillMatrix(int row, int col, int minrange, int maxrange)
{
    int[,] tempmatrix = new int[row, col];
    Random rand = new Random();
    for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
            tempmatrix[i,j] = rand.Next(minrange, maxrange); // генерация случайных вещественных чисел
        }
    }
    return tempmatrix;
}

void FindNum(int[,] tempmatrix, int num)
{
    int getrow = 0;
    int getcol = 0;
    if(num > tempmatrix.GetLength(0) *  tempmatrix.GetLength(1)){
       System.Console.WriteLine("такого числа нет в массиве");
        return;
    }
    getrow = num / tempmatrix.GetLength(0);
    getcol = num % tempmatrix.GetLength(0);
    System.Console.WriteLine($"{tempmatrix[getrow, getcol]}");
}

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] tempmatrix)
{
     for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
            System.Console.Write(tempmatrix[i,j] + "\t");    // печать значение через отступ с табуляцией
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите число строк: ");
int cols = ReadInt("Введите число столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
int num = ReadInt("Введите число: ");
FindNum(matrix, num);