using System;
using System.Collections.Generic;
using System.Text;

namespace problemOne
{
    public class RoverPosition
    {
        public int x { get; set; }
        public int y { get; set; }
        public Heading heading { get; set; }

        public RoverPosition(int X, int Y, Heading Heading)
        {
            this.x = X;
            this.y = Y;
            this.heading = Heading;
        }

    }
}
