// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
internal class NewBaseType
{
    private static void Main(string[] args)
{
Console.Write("Введите элементы(через пробел): ");
int[] num = new int[5];

   
        for (int i = 0; i < num.Length; i++)
        {
            int Result = 0;

            if (num[i] > 0)
            {
                Result = num[i];
             }
            
              Result++;
            
            
            Console.WriteLine($"количество элементов > {Result}");



        }
    }
}

internal partial class Program : NewBaseType
{
}
