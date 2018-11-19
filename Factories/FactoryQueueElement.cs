using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        public FactoryQueueElement(Type model, string name, ICoordinates parkingPos, ICoordinates workingPos)
        {
            Model = model;
            Name = name;
            ParkingPos = parkingPos;
            WorkingPos = workingPos;
        }

        public string Name { get; set; }
        public Type Model { get; set; }
        public ICoordinates ParkingPos { get; set; }
        public ICoordinates WorkingPos { get; set; }
    }
}
