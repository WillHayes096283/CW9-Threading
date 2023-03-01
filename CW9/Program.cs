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
            Console.WriteLine("Please enter the number of throws each thread should make: ");
            int numThrows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of threads to make: ");
            int numThread = Convert.ToInt32(Console.ReadLine());

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

                Console.WriteLine("Evaulation: " + eval);
            }

            Console.ReadKey();
        }
    }
}
