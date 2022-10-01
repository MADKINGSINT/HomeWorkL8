int m = 4, n = 3;
int[,] array = new int[m, n];
CreateRandomArray(array);
PrintArray(array);
int min = Int32.MaxValue;
int IndexOfLineWithMinIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        IndexOfLineWithMinIndex++;
    }
}

Console.WriteLine($"наименьшая сумма {min} в строке {IndexOfLineWithMinIndex}");

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
       
        Console.WriteLine("");
    }
}
