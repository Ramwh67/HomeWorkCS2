using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void ifWeekend(int weekday)
            {
                if (weekday >= 1 && weekday <=5)
                   Console.WriteLine("Будний день");
                else if (weekday == 6 || weekday == 7)
                    Console.WriteLine("Выходной!");
                else Console.WriteLine("Такого дня не существует, введите другое число");
            }

            Console.Write("Введите число соответствующее дню недели ");
            int num = Convert.ToInt32(Console.ReadLine());
            ifWeekend(num);
        }
    }
}