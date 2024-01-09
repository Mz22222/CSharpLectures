/*
Дано 10 гирь с разным весом в случайном порядке. 
Определить вес самой тяжелой гири.
*/

int N = 5;
int[] array = { 14, -4, -57, 3, 9 };
int i = 0;
int max = array[0];

while (i < N)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Write(max);


/* решение данной задачи с помощью цикла for

int[] arr = { 1,2,3,4,5};
fir(int i = 1; i < arr.Length; i = i + 1)
{
    Console.Write($"{arr[i]} ");
}

 */
