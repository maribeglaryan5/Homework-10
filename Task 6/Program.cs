﻿namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, rem, temp, sum = 0;
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
        }
    }
}
