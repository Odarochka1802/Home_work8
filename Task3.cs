/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

try
{
    Console.Write("Введите количество строк 1 массива: ");
    int rowsA = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов 1 массива: ");
    int columnsA = int.Parse(Console.ReadLine());
    Console.Write("Введите количество строк 2 массива: ");
    int rowsB = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов 2 массива: ");
    int columnsB = int.Parse(Console.ReadLine());

    if (columnsA != rowsB)
    {
        Console.WriteLine("Произведение этих матриц невозможно");
        return;
    }

    int[,] firstArray = GetArray(rowsA, columnsA);
    int[,] secondArray = GetArray(rowsB, columnsB);
    Console.WriteLine("Первый массив:");
    printArrayToConsole(firstArray);
    Console.WriteLine("Второй массив:");
    printArrayToConsole(secondArray);
    Console.WriteLine("Результирующий массив:");
    printArrayToConsole(GetMultiplicationMatrix(firstArray, secondArray));

    int[,] GetArray(int m, int n)
    {
        int[,] result = new int[m, n];
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = random.Next(1, 9);
            }
        }
        return result;
    }

    void printArrayToConsole(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] GetMultiplicationMatrix(int[,] firstArray, int[,] secondArray)
    {
        int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
        return resultArray;
    }
}
catch
{
    Console.WriteLine("Неверно внесены значения!");
}