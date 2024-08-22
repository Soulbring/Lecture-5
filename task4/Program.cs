//Замена отрицательных элементов в массиве


void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int min = ReadInt("Введите минимальное число для рандома: ");
    int max = ReadInt("Введите максимальное число для рандома: ");

    int[,] matrix = CreateRandomMatrix(row, col, min, max);
    

    PrintMatrix(matrix);
    PrintMatrix(ReplaceNegNum(matrix));
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
                matrix[i, j] = rnd.Next(MinNumber, MaxNumber + 1);
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
    System.Console.WriteLine();
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


int[,] ReplaceNegNum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                matrix[i, j] = matrix[i, j] * -1;
            }
        }
        
    }
    return matrix;
}
    Main();