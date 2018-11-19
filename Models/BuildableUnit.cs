using BotFactory.Interface;

namespace Models
{
    public abstract class BuildableUnit : IBuildableUnit
    {
        public double BuildTime { get; set; }
        public string Model { get; }
        public BuildableUnit(double buildTime = 5)
        {
            this.BuildTime = buildTime;
        }
    }
}
