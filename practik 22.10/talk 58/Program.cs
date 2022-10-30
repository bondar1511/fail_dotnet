// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = {          { 2, 4 },
                                   { 3, 2 },
                };
        int[,] matrix2 = {          { 3, 4 },
                                    { 3, 3 },
                  };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            
                Console.Write($"{matrix[i, j] + " "}");
                    Console.Write(" | ");
         
            //   for (int n = 0; n < matrix2.GetLength(0); n++)
                  

                    for (int k = 0; k < matrix2.GetLength(1); k++)
                    
                        Console.Write($"{matrix2[i, k] + " " }");
                     Console.WriteLine();
                                          
                      }
        //   void DivMatrix(int[,] matrix, int[,] matrix2);
          int result = 0;
          for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            for (int k = 0; k < matrix2.GetLength(1); k++)
            { 
          
                  result += matrix[i,j]*matrix2[j,k];
                  Console.Write($" {result} " , " ");
           }
       
        Console.WriteLine();
        }
    
    }
}
    
