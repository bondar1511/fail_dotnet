// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


internal class Program
{
    private static int Main(string[] args)
    {
        {
            int[,,] CreateMatrix(int r, int c, int d);
{
            int[,,] Matrix = new int[r, c, d];

            Random rnd = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < Matrix.GetLength(2); j++)
                    {
                        Matrix[i, j, k] = rnd.Next(11, 90);
                    }
                }
            }
            return Matrix;

        }
   
   void PrintMatrix(int[,,] Matrix)
{
    for (int i = 0; i <  Matrix.GetLength(0); i++)
    {
        Console.Write();
        for (int j = 0; j < Matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
            {
            Console.Write($"{Matrix[i, j, k], 1}");            
            }
        }
        Console.WriteLine();        
   
   
    }
}
        }

    }
}
