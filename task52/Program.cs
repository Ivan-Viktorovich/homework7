// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int [,] FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
void NewMatrix(int[,] array, int rows, int columns)
{
    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum+= array[i,j];
        }
        Console.WriteLine($"Ср.арифметическое столбца {j} = {Math.Round(sum / rows, 2)}");
    }
}
int m = new Random().Next(3,7);
int n = new Random().Next(3,7);
int[,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);
NewMatrix(matrix, m, n);
