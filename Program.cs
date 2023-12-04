using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        int result = GetElementValue(matrix, row, col);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента в позиции ({row}, {col}) не существует.");
        }
    }

    static int GetElementValue(int[,] matrix, int row, int col)
    {
        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
        {
            return matrix[row, col];
        }
        else
        {
            return int.MinValue;
        }
    }
}
