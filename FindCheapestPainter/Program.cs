using FindCheapestPainter.Painter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindCheapestPainter
{
    class Program
    {
        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                    .Where(painter => painter.isAvailable)
                    .WithMinimum(painter => painter.EstimateCompensation(sqMeters));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}