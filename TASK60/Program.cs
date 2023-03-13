// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3dMatrixWithRandomNumbers(int[,,] Numbers)
{
  for (int i = 0; i < Numbers.GetLength(0); i++)
  {
    for (int j = 0; j < Numbers.GetLength(1); j++)
    {
      {
        for (int k = 0; k < Numbers.GetLength(2); k++)
        {
          Console.Write($"{Numbers[i, j, k]}({i} + {j} + {k}) ");
        }
      }
    }
    Console.WriteLine();
  }
}

//..Образец.

// void Fill3dMatrixWithRandomNumbers(int[,,] randNumbers, int minValue = 10, int maxValue = 20)
// {
//   Random number = new Random();
//   for (int i = 0; i < randNumbers.GetLength(0); i++)
//   {
//     for (int j = 0; j < randNumbers.GetLength(1); j++)
//     {
//       for (int k = 0; k < randNumbers.GetLength(2); k++)
//       {
//         randNumbers[i, j, k] = number.Next(minValue, maxValue);
//       }
//     }
//   }
// }

void Fill3dMatrixWithRandomNumbers(int[,,] randNumbers)
{
  int countMoreTwo = 10;  // Добавили счетик. Условие = Двухзначые числа
  for (int i = 0; i < randNumbers.GetLength(0); i++)
  {
    for (int j = 0; j < randNumbers.GetLength(1); j++)
    {
      for (int k = 0; k < randNumbers.GetLength(2); k++)
      {
        randNumbers[i, j, k] += countMoreTwo; // Проходя весь цикл добавляется новое 2х значное число в 3д массив
        countMoreTwo += 1; // Увеличиваем счетчик, чтобы числа не повторялись. 
      }
    }
  }
}

int[,,] matrix = new int[2, 2, 2];

Fill3dMatrixWithRandomNumbers(matrix);
Console.WriteLine("3D Матрица 2 x 2 x 2 \n");
Print3dMatrixWithRandomNumbers(matrix);
Console.WriteLine("\n");