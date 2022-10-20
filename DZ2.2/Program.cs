using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void printThirdDigit()
            {
                Console.Write("Введите трёхзначное число ");
                int num = Convert.ToInt32(Console.ReadLine());
                num = Math.Abs(num);

                if ((int)Math.Log10(num) < 2)
                {
                    Console.WriteLine("Третьей цифры нет");
                }
                else
                {
                    string s = Convert.ToString(num);
                    Console.WriteLine($"Третья цифра заданного числа {s[2]}");
                }
            }

            printThirdDigit();
        }
    }
}