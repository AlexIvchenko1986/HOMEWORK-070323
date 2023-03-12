// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortNumbersFromHighToLow(int[,] sorting)
{
  Random number = new Random();
  for (int i = 0; i < sorting.GetLength(0); i++)
  {
    for (int j = 0; j < sorting.GetLength(1); j++)
    {
      //int maxPosition = sorting[i, j]; Хотел сделать сортировка через доп. переменную.
      for (int k = 0; k < sorting.GetLength(1) - 1; k++)
      {
        if (sorting[i, k] < sorting[i, k + 1])
        {
          int temp = sorting[i, k +1];
          sorting[i, k +1] = sorting [i,k];
          sorting [i,k] = temp;
        }
      }
    }
  }
}

int[,] matrix = new int[3, 4];


FillMatrixWithRandomNumbers(matrix);
Console.WriteLine("Матрица 3 x 4 \n");
PrintMatrixWithRandomNumbers(matrix);
SortNumbersFromHighToLow(matrix);
Console.WriteLine();
PrintMatrixWithRandomNumbers(matrix);