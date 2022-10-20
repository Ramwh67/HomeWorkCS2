using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            int getSecondDigit()
            {
                Console.Write("Введите трёхзначное число ");
                int num = Convert.ToInt32(Console.ReadLine());
                num = Math.Abs(num);

                if ((int)Math.Log10(num) == 2)
                {
                    int a = num/100;
                    num = num - a*100;
                    a = num % 10;
                    num = (num - a)/10;
                    return num;
                }
                else
                {
                    Console.WriteLine("Число не является трёхзначным");
                    return -1;
                }
            }

            Console.WriteLine(getSecondDigit());
        }
    }
}