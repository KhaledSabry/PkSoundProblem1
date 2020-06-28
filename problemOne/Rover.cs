using System;
using System.Collections.Generic;
using System.Text;

namespace problemOne
{
    public class Rover
    {
        public RoverPosition currentLocation { get; set; }
        public string state
        {
            get { return string.Format("{0} {1} {2}", this.currentLocation.x, this.currentLocation.y, this.currentLocation.heading); }
        }
        public Rover(int x, int y, Heading heading) // construct a new rover by knowing its intial location  
        {
            this.currentLocation = new RoverPosition(x, y, heading);
        }
        public void executeCommand(MovingCommand command)
        {
            switch (command)
            {
                case MovingCommand.R://spin 90 dgrees right
                    this.currentLocation.heading = (this.currentLocation.heading == Heading.W) ? Heading.N : this.currentLocation.heading + 1;
                    break;
                case MovingCommand.L://spin 90 dgrees left
                    this.currentLocation.heading = (this.currentLocation.heading == Heading.N) ? Heading.W : this.currentLocation.heading - 1;
                    break;
                case MovingCommand.M://move one grid point forward
                    switch (this.currentLocation.heading)
                    {
                        case Heading.N:
                            this.currentLocation.y++;
                            break;
                        case Heading.E:
                            this.currentLocation.x++;
                            break;
                        case Heading.S:
                            this.currentLocation.y--;
                            break;
                        case Heading.W:
                            this.currentLocation.x--;
                            break;
                    }

                    break;
            }
        }
    }
}
