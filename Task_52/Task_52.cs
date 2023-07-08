// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindAverage(int[,] tempmatrix) 
{
    int row = tempmatrix.GetLength(0);
    int col = tempmatrix.GetLength(1);
    double temp = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < row; j++)
    {
        for(int i = 0; i < col; i++)
        {
            temp = temp + tempmatrix[j,i];
        }
        temp = Math.Round(temp/col, 2);
        System.Console.Write($"{temp}; ");
    
    }
}

int rows = ReadInt("Введите число строк: ");
int cols = ReadInt("Введите число столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
FindAverage(matrix);