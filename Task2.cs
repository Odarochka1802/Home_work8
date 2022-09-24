/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/

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

//Метод подсчета суммы строки 
int returnSumString(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
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
printArrayToConsole(array);

int minSumLine = 0;
int sumLine = returnSumString(array, 0);

//Ищем минимальную строку
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = returnSumString(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой - {minSumLine + 1}. Сумма всех элементов - {sumLine}");