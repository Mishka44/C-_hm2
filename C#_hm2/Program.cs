using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__hm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int[][] arr_hall = new int[18][];
            for (int i = 0; i <= 5; i++)
            {
                arr_hall[i] = new int[7];
                for (int j = 0; j < 7; j++)
                {
                    arr_hall[i][j] = rnd.Next(0, 2);
                }
            }
            for (int i = 6; i < 12; i++)
            {
                arr_hall[i] = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    arr_hall[i][j] = rnd.Next(0, 2);
                }
            }
            for (int i = 12; i < 18; i++)
            {
                arr_hall[i] = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    arr_hall[i][j] = rnd.Next(0, 2);
                }
            }
            Console.WriteLine("Добро пожаловать в кинотеатр!");
            Console.WriteLine("Просим вас ознокомиться со свободными местами: 0 - свободно, 1 - занято");
            foreach (var array in arr_hall)
            {
                foreach (var item in array)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
            }

        }
    }
}
