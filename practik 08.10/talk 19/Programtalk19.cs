// Задача 19/ Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да

        int [] nums = {14212};
        static void Palindrom(string x)
        {  
           char[] tx = x.ToCharArray();
            Array.Reverse(tx);
            string tx1 = new string(tx);
            if (x == tx1)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
        }
