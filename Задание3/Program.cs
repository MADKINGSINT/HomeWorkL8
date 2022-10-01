int m  = 2, n = 2;
int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] MatrixInAnswer = new int[m, n];

CreateRandomArray(matrix);
PrintArray(matrix);

Console.WriteLine();

CreateRandomArray(matrix2);
PrintArray(matrix2);

Console.WriteLine();

if (matrix.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        MatrixInAnswer[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            MatrixInAnswer[i, j] += matrix[i, k] * matrix2[k, j];
        }
    }
}

PrintArray(MatrixInAnswer);





void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}







