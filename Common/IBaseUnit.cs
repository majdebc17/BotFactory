using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IBaseUnit : IBuildableUnit
    {
        string Name { get; set; }
        double Vitesse { get; set; }
        Coordinates currentPos { get; set; }
    }
}
