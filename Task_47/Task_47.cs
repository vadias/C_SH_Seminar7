// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] FillMatrix(int row, int col, int max)
{
    double[,] tempmatrix = new double[row, col];
    Random rand = new Random();
    for(int i = 0; i < tempmatrix.GetLength(0); i++)        // запонение строк
    {
        for(int j = 0; j < tempmatrix.GetLength(1); j++)    // заполнение столбцов
        {
            tempmatrix[i,j] = Math.Round(rand.NextDouble()*max*2 - max, 2); // генерация случайных вещественных чисел
        }
    }
    return tempmatrix;
}

int ReadInt(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] tempmatrix)
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
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
double[,] matrix = FillMatrix(rows, cols, 10);
PrintMatrix(matrix);