// Поиск максимального элемента в каждой строке

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int min = ReadInt("Введите минимальное число для рандома: ");
    int max = ReadInt("Введите максимальное число для рандома: ");
    
    int [,] matrix = CreateRandomMatrix(row, col, min, max); 
    PrintMatrix(matrix);
    FindMaxNumber(matrix);
}

int[,] CreateRandomMatrix(int RowLength, int ColLenght, int MinNumber, int MaxNumber)
{

    Random rnd = new Random();
    int[,] matrix = new int[RowLength, ColLenght];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(MinNumber, MaxNumber+1);
            }
        }
        return matrix;
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string msg)
{
    while (true)
    {
        Console.Write(msg);
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}


void FindMaxNumber(int [,] matrix)
{
    int max = 0;
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        max = matrix[i,0];
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            if(matrix[i,j] > max)
            {
                max = matrix[i,j];
            }
        }
        System.Console.WriteLine($"Максимальное число в {i+1} строчке: {max}");
        
    }

}

Main();














