using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game_speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int count = 0;

            int remaining_time_s = 60;

            string chars = "abcdefghijklmnopqrstuvwxyz";
            chars += chars.ToUpper();

            Random random = new Random();

            Console.WriteLine("You Have '" + remaining_time_s + "' Seconds To Enter Any Correct Char You Can.");
            Console.WriteLine("Correct Answers Increase You'r Point 1 Unit.");
            Console.WriteLine("Incorrect Answers Decrease You'r Point 2 Unit.");
            Console.WriteLine("Prese Any Key To Start: ");

            Console.ReadKey(intercept: true);
            Console.Clear();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds / 1000 < remaining_time_s) 
            {
                char random_char = chars[random.Next(chars.Length)];
                Console.WriteLine("Press '" + random_char + "' from keyboard.");
                Console.WriteLine("Points: " + count);

                if (Console.ReadKey(intercept: true).KeyChar == random_char)
                    count++;
                else
                    count -= 2;

                Console.Clear();
            }

            Console.WriteLine("Your Final Point Is: " + count);
            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadLine();
        }
    }
}
