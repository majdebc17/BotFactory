using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class R2D2 : BaseUnit
    {
        public R2D2() : base("R2D2", 1.5)
        {
            BuildTime = 5.5;
        }
    }
}
