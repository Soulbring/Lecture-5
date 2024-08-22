// Поиск суммы элементов в каждай строке


void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int min = ReadInt("Введите минимальное число для рандома: ");
    int max = ReadInt("Введите максимальное число для рандома: ");

    int[,] matrix = CreateRandomMatrix(row, col, min, max);
    PrintMatrix(matrix);
    RowSummElements(matrix);
    ColumSummElements(matrix);
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

void RowSummElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        System.Console.WriteLine($"Сумма элементов в {i + 1} строчке равна: {sum}");
    }
    System.Console.WriteLine();
}

void ColumSummElements(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        System.Console.WriteLine($"Сумма элементов в {j + 1} столбце равна: {sum}");
    }
    System.Console.WriteLine();
}

Main();