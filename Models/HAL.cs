using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HAL : BaseUnit
    {
        public HAL() : base("HAL", 0.5)
        {
            BuildTime = 7;
        }
    }
}
