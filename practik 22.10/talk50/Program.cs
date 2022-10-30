

        // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет



internal class Program
{
    private static void Main(string[] args)
    {
    Console.Write("Введите индекс строки: ");
      var line = Convert.ToInt32 (Console.ReadLine());
      Console.Write("Введите индекс столбца: ");
      var column =  Convert.ToInt32 (Console.ReadLine());
    int [,] tabl = new int[3,4];

        Random rnd = new Random();
       
       {
         for (int i = 0; i < tabl.GetLength(0); i++)
        {
            for (int j = 0; j < tabl.GetLength(1); j++)
            {
                tabl[i, j] = rnd.Next(1, 60);
              System.Console.Write($"{tabl[i, j]} ");
            }
             
           Console.WriteLine();
}
}
Console.WriteLine("Введите значение элемента: ");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>line && b>column)
 Console.WriteLine("такого числа нет");
 else
 {
 tabl.GetValue(a,b);
 Console.WriteLine();

}
}
}

