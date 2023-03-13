// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
//элементов: 1 строка

void PrintMatrixWithRandomNumbers(int[,] Numbers)
{
  for (int i = 0; i < Numbers.GetLength(0); i++)
  {
    for (int j = 0; j < Numbers.GetLength(1); j++)
    {
      Console.Write($"{Numbers[i, j]}; ");
    }
    Console.WriteLine();
  }
}

void FillMatrixWithRandomNumbers(int[,] realNumbers, int minValue = 1, int maxValue = 20)
{
  Random number = new Random();
  for (int i = 0; i < realNumbers.GetLength(0); i++)
  {
    for (int j = 0; j < realNumbers.GetLength(1); j++)
    {
      realNumbers[i, j] = number.Next(minValue, maxValue);
    }
  }
}

void FindRawWithMinSumOfElements(int[,] elements)
{
  int minLine = 0;
  int minSumInLine = 0;
  int sumInLine = 0;
  for (int i = 0; i < elements.GetLength(1); i++)
  {
    minLine += elements[0, i];
  }
  for (int i = 0; i < elements.GetLength(0); i++)
  {
    for (int j = 0; j < elements.GetLength(1); j++) sumInLine += elements[i, j];
    if (sumInLine < minLine)
    {
      minLine = sumInLine;
      minSumInLine = i;
    }
    sumInLine = 0;
  }
  Console.Write($"номер строки c наименьшей суммой элементов = {minSumInLine +1}");   // {minSumInLine}");
}


int[,] matrix = new int[4, 4];


FillMatrixWithRandomNumbers(matrix);
Console.WriteLine("Матрица 4 x 4 \n");
PrintMatrixWithRandomNumbers(matrix);
Console.WriteLine("\n");
FindRawWithMinSumOfElements(matrix);
