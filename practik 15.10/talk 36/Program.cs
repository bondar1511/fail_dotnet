// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write ("ВВедите размер массива");
        int element = int.Parse(Console.Readlite());
        int[] array = new int [element];
        int Result = 0;
    
        for (int i = 0; i < array.Length; i++);
        {
            Console.WriteLine ($"ВВедите элемент массива с индексом {i}");
            array [i] = int.Parse(Console.Readlite());
        }       

        Console.WriteLine ($"Вывод массива");
           
            for (int i = 0; i < array.Length; i++) ;
           
            if (array[i] % 2 != 0);
            {
                Result += array[1];
            }
                
            Console.WriteLine (Result);
        }
           
          
                }
