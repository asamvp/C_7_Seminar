/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateMatrix() //создаем массив
{
    int[,] matrix = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintArray(int[,] array) //печатаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
void ArithmeticMean(int[,] array) // находим и выводим ср арифметическое
{   
    double sred=0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sred=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sred=sred+array[j, i];
        }
        System.Console.Write($"Ср арифметичесое стоблца {i+1} = {sred/array.GetLength(0)}.  ");
    }
}
Console.Clear();
int[,] matrix = CreateMatrix();
PrintArray(matrix);
ArithmeticMean(matrix);