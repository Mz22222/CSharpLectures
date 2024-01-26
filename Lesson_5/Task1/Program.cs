/*
Вычислить факториал от натурального числа N 
(факториал - произведение чисел от 1 до самого числа N включительно )
 3! = 1*2*3 = 6

 1! = 1
 0! = 1
*/

using System.Collections.ObjectModel;

int Fact(int n)
{
    if (n == 1 || n == 0) // || -  или 
    {
        return 1; // вернем 1 т.к. 1! равен 1
    }
    return n * Fact(n - 1);
}

Console.Write(Fact(0));