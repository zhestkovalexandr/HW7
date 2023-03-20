/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


double[,] array1 = CreateRandom2DArray(_sizeM: 3, _sizeN: 4, _minValue: -100f, _maxValue: 101f);
Print2DArray(array1);
Divider(screenWidth);


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет*/



int[,] array2 = CreateRandom2DArray(_sizeM: 3, _sizeN: 4, _minValue: -100, _maxValue: 101);
Print2DArray(array2);
Console.Write("Введите номер строки (k): ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца (n): ");
int n = Convert.ToInt32(Console.ReadLine());
if (k > 0 && k <= array2.GetLength(0)  && n > 0 && n <= array2.GetLength(1))
{
    TPoint point = new TPoint(_row: k - 1, _column: n -1);
    Console.WriteLine("Элемент с индексами ({0}, {1}) = {2}", k, n, FindElementIn2DArray(_point: point, _array: array2));
}
else
{
    Console.WriteLine("Индекс выходит за границы диапазона. Элемента с такими индексами ({0}, {1}) в массиве нет", k, n);
}
Divider(screenWidth);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] array3 = CreateRandom2DArray(_sizeM: 4, _sizeN: 4, _minValue: -100, _maxValue: 101);
Print2DArray(array3);
double[] array4 = AverageColumnFromArray(array3);
Divider(32);
PrintArray(array4); 
Console.WriteLine();
Console.WriteLine(divider);
Console.ReadKey();
