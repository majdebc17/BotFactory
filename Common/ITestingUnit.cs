using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface ITestingUnit: IReportingUnit, IWorkingUnit
    {
        string Name { get; set; }
        double Vitesse { get; set; }
        Coordinates CurrentPos { get; set; }
        double BuildTime { get; set; }
        string Model { get; set; }
    }
}
