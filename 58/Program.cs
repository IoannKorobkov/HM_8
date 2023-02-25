// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstmatrix = new int[m, n];
int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
int p = Convert.ToInt32(Console.ReadLine());
int[,] secondmatrix = new int[n, p];
int[,] result = new int[m, p];

FillArray(firstmatrix);
PrintArray(firstmatrix);
Console.WriteLine();
FillArray(secondmatrix);
PrintArray(secondmatrix);
Console.WriteLine();

void Product(int[,] matrix, int[,] matrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < result.GetLength(1); k++)// k цикл вводится для того чтобы увеличивать i и j
            {
                sum = sum + (firstmatrix[i, k] * secondmatrix[k, j]);
                Console.WriteLine(sum);
            }
            result[i, j] = sum;
        }
    }
}
int[,] PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
Product(firstmatrix, secondmatrix, result);
PrintArray(result);

