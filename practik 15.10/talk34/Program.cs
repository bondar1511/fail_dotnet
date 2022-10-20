// Задача 34: Задайте массив заполненный случайными положительными n
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();

        int[] array = new int[] { 345, 897, 568, 234 };
        int count = 0;
        int n = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
      while (array[i] % 2 == 0); 
      {
                    ;
            count++;           
       }
     
     Console.WriteLine($"из {array.Length} чисел, {count} четных");
        }
    }
}
