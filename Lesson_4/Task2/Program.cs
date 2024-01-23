/*
Назовём число "интересным" если его сумма цифра чётная.

Создать двумерный массив, состоящий из целых чисел.
Вывести на экран "интересные" элементы массива
*/



int[,] CreateMatrix(int rowCount, int columsCount)
{

    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}


int[,] matrix = CreateMatrix(1, 5);
ShowMatrix(matrix);

foreach (int c in matrix)
{
    if (IsInteresting(c) == true)
    {
        Console.WriteLine(c);
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10; // получим самую правую цифру нашего числа
        value = value / 10;
    }
    return sum;
}


void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

