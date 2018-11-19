using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Wall_E : BaseUnit
    {
        public Wall_E() : base("Wall-E", 2)
        {
            BuildTime = 4;
        }
    }
}
