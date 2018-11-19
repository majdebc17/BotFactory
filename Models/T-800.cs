using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class T_800 : BaseUnit
    {
        public T_800() : base("T-800", 3)
        {
            BuildTime = 10;
        }
    }
}
