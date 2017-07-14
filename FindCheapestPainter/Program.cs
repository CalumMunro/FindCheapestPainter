using FindCheapestPainter.Painter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

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

        private static IPainter FindFastestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                    .Where(painter => painter.isAvailable)
                    .WithMinimum(painter => painter.EstimateTimeToPaint(sqMeters));
        }

        private static void WorkTogether(double sqMeters, IEnumerable<IPainter> painters)
        {
            TimeSpan time =
                TimeSpan.FromHours(
                    1 /
                    painters
                        .Where(painter => painter.isAvailable)
                        .Select(painter => 1 / painter.EstimateTimeToPaint(sqMeters).TotalHours)
                        .Sum());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}