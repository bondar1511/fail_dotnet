// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

internal class Program
{
    private static void Main(string[] args)
    {

        
        int[,] array = {    { 1, 4, 7, 2 },
                            { 5, 9, 2, 3 },
                            { 8, 4, 2, 4 }};


        // void FillArray (int[,] array);
         for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
              System.Console.Write($"{array[i, j]} ");
            
            }

                  System.Console.WriteLine();
         }
    
         int SrAr = 0;
         int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
           {
          
            sum +=array[i,j];
            SrAr =sum/array.GetLength(1);
          
            }
          System.Console.WriteLine($"Среднее арифмитическое значение: {SrAr}.");  

          }
           System.Console.WriteLine();
    }
}
