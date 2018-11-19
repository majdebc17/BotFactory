using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IWorkingUnit
    {
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }
        bool IsWorking { get; set; }
        Task<bool> WorkBegins();
        Task<bool> WorkEnds();
    }
}
