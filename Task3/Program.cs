void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] MeanArray(int[,] numbers)
{
    double[] meanNumbers = new double[numbers.GetLength(1)];

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        int sum = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }

        double mean = Convert.ToDouble(sum) / Convert.ToDouble(numbers.GetLength(0));
        meanNumbers[j] = Math.Round(mean, 1);
    }

    return meanNumbers;
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
double[] meanNumbers = new double[columns];

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);
Console.WriteLine();
meanNumbers = MeanArray(numbers);
WriteArray(meanNumbers);