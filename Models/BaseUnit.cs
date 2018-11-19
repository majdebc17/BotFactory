using BotFactory.Interface;
using Common.Tools;
using System;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseUnit : BuildableUnit, IBaseUnit
    {
        public string Name { get; set; }
        public double Vitesse { get; set; }
        public Coordinates currentPos { get; set; }

        public BaseUnit(string name, double vitesse = 1)
        {
            this.Name = name;
            this.Vitesse = vitesse;

            currentPos = new Coordinates(0, 0);
        }
        public async Task<bool> Move(Coordinates coordinates)
        {
            Vector vector = Vector.FromCoordinates(currentPos, coordinates);
            double distance = vector.Length();
            double time = distance / Vitesse;

            await Task.Run(async () =>
           {
               await Task.Delay((int)Math.Round(time));
               return true;
           });
            return false;
        }
    }
}
