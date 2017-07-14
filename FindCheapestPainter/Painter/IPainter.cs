using System;
using System.Collections.Generic;
using System.Text;

namespace FindCheapestPainter.Painter
{
    public interface IPainter
    {
        bool isAvailable { get; }
        TimeSpan EstimateTimeToPaint(double sqMeters);
        double EstimateCompensation(double sqMeters);
    }
}
