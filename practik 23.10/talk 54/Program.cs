// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2






internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = {   { 1, 4, 7, 2 },
                            { 5, 9, 2, 3 },
                            { 8, 4, 2, 4 }};

        void FillArray(int[,] matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                System.Console.Write($"{matrix[i, j]} ");
            }

            System.Console.WriteLine();
        }



        static void SortoLower(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); i++)
                {
                    for (int n = 0; n < matrix.GetLength(1) - 1; n++)
                    {
                        if (matrix[i, j] > matrix[j, i + 1])
                        {

                            int temp = matrix[j, n + 1];
                            matrix[j, n + 1] = matrix[i, n];
                            matrix[i, n] = temp;

                        }


                    }



                }

            }
          void PrintArray(int[,] matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    System.Console.Write($"{matrix[i, j]} ");
                }

                System.Console.WriteLine();


            }




        }
}
}
