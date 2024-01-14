/*
Вычислить значение формулы (a*b)/(c+d), 
где a, b, c, в - некоторые целые числа. 
Решение оформить в виде функции.
 
решение без функции: 
int a = 4;
int b = 25;
int c = 3;
int d = 2;

int product = a * b;
int sum = c + d;
int quotient = product / sum;

Console.WriteLine(quotient);
*/

double CalculateFormula(int a, int b, int c, int d) // переводится кк вычисли значение формулы
{
    double numerator = a * b; // переводится как числитель
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);

Console.Write(result);

