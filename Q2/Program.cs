using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //題目：使用while，在畫面顯示所有可以整除300的整數

            int number = 1;
            while (number <= 300)
            {
                if (300 % number == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }


        }
    }
}
