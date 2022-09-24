/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
int n = 0;
int m = 0;

Console.Write("Введите количество строк: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numN);
Console.Write("Введите количество строк: ");
bool boolM = int.TryParse(Console.ReadLine(), out int numM);
if (boolN && boolM)
{
    n = numN;
    m = numM;
}
else
    Console.WriteLine("Неверный ввод! Введиче целое числовое значение.");




//Создаем массив и заполняем рандомными числами
int[,] fillArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 20);
        }
    }
    return array;
}


//Сортируем массив
void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

//Вывод массива
void printArrayToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = fillArray(n, m);
Console.WriteLine("Наш массив: ");
printArrayToConsole(array);

Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
printArrayToConsole(array);
