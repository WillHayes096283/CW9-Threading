/*
 * @file: FindPiThread.cs
 * @author: William Hayes
 * @date:3/3/2023
 * @brief: This is the FindPiThread file that calculates the number of throws 
 * that made it into a circle.
 * 
 * This file helps calculate the number of throws that made it into a circle
 * for the purpose of finding pi.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW9
{
    public class FindPiThread
    {
        int numDarts;
        int count;

        Random rnd;

        public FindPiThread(int numDarts)
        {
            rnd = new Random();

            this.numDarts = numDarts;
            this.count = 0;
        }

        public int getCount() 
        {
            return count;
        }

        public void throwDarts()
        {
            while (numDarts > 0)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();

                double val = Math.Sqrt((x * x) + (y * y));

                if (val <= 1.0)
                {
                    numDarts--;
                    count++;
                }

                else
                {
                    numDarts--;
                }
            }
        }



    }
}
