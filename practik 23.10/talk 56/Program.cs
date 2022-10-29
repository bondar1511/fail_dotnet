// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  int[,] matrix = {      { 1, 4, 7, 2 },

//         {
internal partial class Program
{
    private static int[,] Main(string[] args)
    {
        int[,] rectan = new int[4, 8];

         Random rnd = new Random();
        for (int i = 0; i < rectan.GetLength(0); i++)
        {
            for (int j = 0; j < rectan.GetLength(1); j++)
            {
                rectan[i, j] = rnd.Next(5, 25);

            }
      return rectan;

        }
}

    private static void PrintMatrix(int[,] rectan)
    {
        for (int i = 0; i < rectan.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < rectan.GetLength(1); j++)
            {
                if (j < rectan.GetLength(1) - 1) Console.Write($"{rectan[i, j],1}|");
                else Console.Write($"{rectan[i, j],1}");
            }
            Console.WriteLine("|");
        }

      }

    void SumStringMatrix(int[,] rectan)
{
    int index = 0;
    for (int i = 0; i <rectan.GetLength(0); i++)
    {
        int sum = 0;
        int minsum = 0;
        for (int j = 0; j < rectan.GetLength(1); j++)
        {
            sum += rectan[i, j];
            if (sum <= minsum) sum = minsum;
            index = i;        
                   }
        Console.Write($"Строка с минимальной суммой элементов равна {  rectan [index, j ]}. ");
    }          


}

}