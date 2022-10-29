
// Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6
// Одно из решений :
// Группа 1: 1 
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 7 16 24 36 40 
// Группа 6: 5 32 48


       Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.Read());
         
            int[] number = new int[N];
 
            for(int i = 0; i < N; i++)
            {
                number[i] = i + 1;
            }
 
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 1) Console.WriteLine("Группа {0}", number[i]);
                Console.Write("Группа  "," ");
                for (int j = 1; j < number.Length; j++)
                {
 
                    if (number[i] != 0 && number[j] % number[i] != 0)
                    {
 
                        Console.Write($"{number[j]} ");
                        number[j] = 0;
                    }
 
                }
                Console.WriteLine();
    
 
            Console.ReadLine();
}