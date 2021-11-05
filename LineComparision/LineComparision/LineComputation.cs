using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class LineCalculation
    {
        int xOnePt, xTwopt, yOnept, yTwopt;
        public void LineComputation(int xOnePt, int xTwopt, int yOnept,int yTwopt)
        {
            this.xOnePt = xOnePt;
            this.xTwopt = xTwopt;
            this.yOnept = yOnept;
            this.yTwopt = yTwopt;
        }
        public void lengthMeasurement()
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(this.xTwopt - this.xOnePt, 2) + (Math.Pow(this.yTwopt - this.yOnept, 2))));
        }
    }
}
