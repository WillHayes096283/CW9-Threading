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
                double x = rnd.Next(0, 6);
                double y = rnd.Next(0, 6);

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
