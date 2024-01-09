int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;

Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

//Console.WriteLine(arr[5]);  нельзя выходить за рамки указанной памяти 

//2-й способ заполнения массива (упрощенный вариант указания значений)

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

//В С# можно обойтись и без указания количества выделения памяти
//т.к. число элементов у нас фиксировано и мы их указываем сразу при создании массива
int [] arr3 = {1,2,3,4,5}

