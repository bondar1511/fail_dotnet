// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
// [3 7 22 2 78] -> 76

 internal partial class Program
{
    private static void Main(string[] args)
    {

var array = new decimal[3,7,22,2,78];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите {0} число : ");
                array[i] = Convert.ToDecimal(Console.ReadLine());
            }
 
            var max = array[0];
            var min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            
            Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
    }
}
