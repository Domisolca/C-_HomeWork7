void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBetween(int number, int min, int max)
{
    return number >= min && number <= max;
}


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

Fill2DArrayRandomNumbers(numbers);
Write2DArray(numbers);

int number = ReadInt("Введите число от 11 до 99: ");

if (!IsBetween(number, 11, 99))
{
    Console.WriteLine("Ваше число должно быть от 11 до 99!");
    return;
}

int row = number/10;
int column = number%10;

if (row > rows || column > columns)
{
    Console.WriteLine("Нет такой позиции!");
}
else
{
    Console.WriteLine(numbers[row - 1, column - 1]);
}