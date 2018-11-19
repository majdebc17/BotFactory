using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IFactoryQueueElement
    {
        string Name { get; set; }
        Type Model { get; set; }
        ICoordinates ParkingPos { get; set; }
        ICoordinates WorkingPos { get; set; }
    }
}
