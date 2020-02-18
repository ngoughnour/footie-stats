using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStatsLib
{
    public class Athlete
    {
        public Athlete(int number)
        {
            Number = number;
            if (number <= -1 || number > 99) {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Must be valid jersey number.");
                    }
            Position = new Position();
        }

        public Position Position;
        public int Number;
        private int _height;

        //for now we will use inches
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 48 || value > 120 )
                {
                    InvalidHeight = true;
                }
                _height = value;
            }
        }

        public int Age;
        public bool InvalidHeight = false;

    }
}
