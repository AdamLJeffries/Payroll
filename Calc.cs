using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll;

static class Calc
{
    public static double CalcWorkedOT (double time, double overTimeHours)
    {
        double workedOverTime = 0;

        if (time > overTimeHours)
            workedOverTime = time - overTimeHours;

        return workedOverTime;
    }

    public static double CalcRegTime (double time, double workedOverTime, double overTimeHours)
    {
        double regularTime = time;

        if (time > overTimeHours)
            regularTime = time - workedOverTime;
        return regularTime;
    }
}