using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //題目：1+2+3+...+N<105。請問N是多少?

            int sum = 0;//總數
            int number = 1;//1~n的數字

            while (sum < 105)
            {
                sum += number;
                number++;
            }
            sum -= number;

            Console.WriteLine($"N是{sum}");

        }
    }
}
