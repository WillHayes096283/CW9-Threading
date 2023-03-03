/*
 * @file: Program.cs
 * @author: William Hayes
 * @date:3/3/2023
 * @brief: This is the main program file.
 * 
 * This is the main program file that uses threads to calculate
 * Pi. The program takes the number throws each thread should simulate
 * and the number of threads. Each thread uses the FindPiThread class
 * to calculate the number of throws that made into a circle, based on
 * the hypotenuse of its (X, Y) coordinates being less than or equal to 1.
 * Finally, the program will take the number of throws that made it in the circle
 * and divide it by the total number of throws each thread made before multiplying
 * by 4. The resulting value should be roughly close to the value of pi.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CW9
{
    public class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0;
            double tThread = 0.0;

            Console.WriteLine("Please enter the number of throws each thread should make: ");
            int numThrows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of threads to make: ");
            int numThread = Convert.ToInt32(Console.ReadLine());

           tThread = Convert.ToDouble(numThread);

            List<FindPiThread> piList = new List<FindPiThread>();
            List<Thread> threads = new List<Thread>();

            while (numThread > 0)
            {
                FindPiThread finder = new FindPiThread(numThrows);
                piList.Add(finder);

                Thread threadObj = new Thread(new ThreadStart(finder.throwDarts));
                threads.Add(threadObj);

                threadObj.Start();
                Thread.Sleep(16);

                numThread--;
            }

            foreach(Thread t in threads)
            {
                t.Join();
            }

            foreach(FindPiThread p in piList)
            {
                int cnt = p.getCount();
                
                double eval = (4.0 * (Convert.ToDouble(cnt) / Convert.ToDouble(numThrows)));

                total += eval;

                Console.WriteLine("Evaulation: " + eval);
            }

            Console.WriteLine();

            Console.WriteLine("Calculated Pi: " + (total/tThread));

            Console.ReadKey();
        }
    }
}
