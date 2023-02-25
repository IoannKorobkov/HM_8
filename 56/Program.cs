// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}
void NumberRowMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow = minRow + array[0, i];//Сумма первой строки, перебирая столбцы и потом примем её за минимум
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow = sumRow + array[i, j]; // Делаем тоже самое ищем сумму строки двойным циклом и потом сравниваем с первым который уже минимум
        Console.WriteLine(sumRow);
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;// объявляем строчку минимум её номер
        }
        sumRow = 0;//обнуляем значение суммы строки
    }
    Console.Write($"{minSumRow + 1} строка");
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
FillArray(array);
PrintArray(array);
NumberRowMinSum(array);
