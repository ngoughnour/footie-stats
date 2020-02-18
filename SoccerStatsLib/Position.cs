using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStatsLib
{
    public enum BasicRole
    {
        Unknown = 0,
        Forward,
        MidField,
        Defender,
        Keeper
    }
    public class Position
    {
        public BasicRole Role;
    }
}
