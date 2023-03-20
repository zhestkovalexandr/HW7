/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// double[,] CreateRandom2dDoubleArray()
// {
//     Console.WriteLine("Please input array rows: ");
//     int rows = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine("Please input array columns: ");
//     int columns = int.Parse(Console.ReadLine() ?? "");
    
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(-100, 100) +  new Random().NextDouble(); // double in range (-100, 100)
//         }
//     }
//     Console.WriteLine();
//     return array;
// }
// void Show2dDoubleArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write("{0:0.00 \t}", array[i, j]);
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// double[,] doubleRandomArray = CreateRandom2dDoubleArray();
// Show2dDoubleArray(doubleRandomArray);



/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет*/

// int[,] Create2drandomArray(int rows, int columns, int MinValue, int MaxValue)
// {

//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(MinValue, MaxValue + 1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ElementDetector(int[,] array, int rows, int columns, int numOfRow, int numOfColumn)
// {
//     if (numOfRow <= rows && numOfRow >= 0
//     && numOfColumn <= columns && numOfColumn >= 0)
//         Console.WriteLine($"the value of this element is {array[numOfRow, numOfColumn]}");
//     else 
//     Console.WriteLine("There is no element");
// }
// Console.Write("Please input number of rows ");
// int rows = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Please input number of columns ");
// int columns = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Please input number of MinValue ");
// int MinValue = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Please input number of MaxValue ");
// int MaxValue = int.Parse(Console.ReadLine() ?? "");

// int[,] Array = Create2drandomArray(rows, columns, MinValue, MaxValue);
// Show2dArray(Array);

// Console.WriteLine("Please enter the row number you need ");
// int numOfRow = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Please enter the column number you need ");
// int numOfColumn = int.Parse(Console.ReadLine() ?? "");

// ElementDetector(Array, rows, columns, numOfRow, numOfColumn);

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// int[,] CreateRandom2dArray()
// {
//     Console.WriteLine("Please input array rows: ");
//     int rows = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine("Please input array columns: ");
//     int columns = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine("Please input array minValue: ");
//     int minValue = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine("Please input array maxValue: ");
//     int maxValue = int.Parse(Console.ReadLine() ?? "");
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }
// void Show2DArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "\t");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void DoubleArrayToConsole(double[] array)
// {
//     Console.WriteLine();
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.Write($"{array[array.Length - 1]}]");
//     Console.WriteLine();
// }
// double[] ArithmeticAvg2dArrayColumns(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         result[j] = (double)sum / array.GetLength(0);
//     }
//     return result;
// }
// int[,] arrayTest = CreateRandom2dArray();
// Console.WriteLine("Here is our array: ");
// Show2DArray(arrayTest);
// double[] arryaArith = ArithmeticAvg2dArrayColumns(arrayTest);
// Console.WriteLine("Here is arithmetic average of each column of array above: ");
// DoubleArrayToConsole(arryaArith);

