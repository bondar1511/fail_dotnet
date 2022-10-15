// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




internal partial class Program
{
    private static void Main(string[] args)
    {
          int[] arr = new int[] { 1, 2, 5, 7, 19 };
      
         Console.WriteLine(string.Join(' ', arr));
    }
}

