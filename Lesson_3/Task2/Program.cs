/*
Вывод на экран квадратов чисел от 1 до N. 
*/

void PrintSquares(int limit) // она ничего не возвращает, поэтому тип данных void 
{
    int i = 1;
    while (i <= limit) 
    {
        Console.Write($"{i * i} ");
        i++; // инкримент 
    }
}

// Для запуска функции её необходимо вызвать 
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);