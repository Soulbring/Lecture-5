// Транспонирование двумерного массива

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int min = ReadInt("Введите минимальное число для рандома: ");
    int max = ReadInt("Введите максимальное число для рандома: ");

    int[,] matrix = CreateRandomMatrix(row, col, min, max);
    int[,] matrix2 = TranparentMatrix(matrix);
    PrintMatrix(matrix);
    PrintMatrix(matrix2);
    
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
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] TranparentMatrix (int[,] matrix)
{

    int[,] transparent = new int[matrix.GetLength(1),matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            transparent[j,i] = matrix[i,j];
        }
        
    }
    return transparent;

}

Main();