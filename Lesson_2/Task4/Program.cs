/*
Дано 10 гирь с разным весом в случайном порядке. 
Определить вес самой тяжелой гири.
*/

// вариант решения данной задачи с помощью цикла while
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
Console.WriteLine(max);


// вариант решения данной задачи с помощью цикла for
max = array[0];
for(int j = 1; j < array.Length; j++)
{
     if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);


// вариант решения данной задачи с помощью цикла foreach
max = array[0];
foreach (int е in array) //обращение по индексу в этом цикле уже не используется  
{
      if (е > max)
    {
        max = е;
    }
}
Console.WriteLine(max);