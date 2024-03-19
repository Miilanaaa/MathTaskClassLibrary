using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class CheckOnEntryPointInCircle
    {
        public CheckOnEntryPointInCircle(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public byte CheckOnEntry(double x, double y)
        {
            byte result = PointInCircle(x, y);
            if (result != 0)
                return result;
            return PointInTringle(x, y);
        }
        private byte PointInCircle(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
            {
                if (x >= 0 && y >= 0)
                    return 1;
            }
            return 0;
        }
        public byte PointInTringle(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2)
                    && Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(R, 2)
                            && (y <= 0 && x <= 0)
                                && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 2*Math.Pow(R, 2)))
                return 2;
            return 0;
        }
    }
}
