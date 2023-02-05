/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
/*bool FindNumberinArray(int[,] array, int N) //написал не ту функцию не понял задание
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N) return true;
        }
    }
    return false;
}*/
Console.Clear();
int a = InputInt("Введите позицию строки > ");
int b = InputInt("Введите позицию столбца > ");
int[,] matrix = CreateMatrix();
PrintArray(matrix);
if (a < 1 || a > 3 || b < 1 || b > 4)
{
    System.Console.WriteLine("Вы вышли за диапазон массива");
}
else
{
    System.Console.WriteLine($"Число в заданной ячейке = {matrix[a-1,b-1]}");
}