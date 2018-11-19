using BotFactory.Interface;
using Common.Tools;
using System.Threading.Tasks;
using System;

namespace Models
{
    public abstract class WorkingUnit : BaseUnit, IWorkingUnit
    {
        public WorkingUnit(string name, double vitesse = 1) : base(name, vitesse)
        {
        }

        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public async Task<bool> WorkBegins()
        {
            return await Move(WorkingPos);
        }
        public async Task<bool> WorkEnds()
        {
            return await Move(ParkingPos);
        }
        
    }
}
