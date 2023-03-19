// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = FillMatrix(rows, columns, 0, 10);
int[,] FillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintMatrix(resultMatrix);

Console.Write("Введите номер сроки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

if(rowNumber > rows || columnNumber > columns)
{
    Console.WriteLine("Такого элемента не существует.");
}
    
else
{
    Console.WriteLine($"Значение элемента: {resultMatrix[rowNumber-1, columnNumber-1]}");
}

