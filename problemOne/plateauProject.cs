using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemOne
{
    public class plateauProject
    {
        public Point plateauCoordinate { get; set; }
        public List<Rover> rovers { get; set; }
        public string state { get { return string.Join("\r\n", rovers.Select(a => a.state)); } }

        public plateauProject(string instructions) // parse the input stirng
        {
            this.rovers = new List<Rover>();

            var lines = instructions.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); //split the inputs to lines
            this.plateauCoordinate = new Point(int.Parse(lines[0].Split(' ')[0]), int.Parse(lines[0].Split(' ')[1]));
            if (!(lines.Length >= 3 && lines.Length % 2 != 0)) // check that lines count more that 3 and odd number 
                throw new System.Exception("invalid instructions format");

            for (int i = 1; i < lines.Length; i = i + 2)
            {
                string RoverInitials = lines[i].Trim();
                string RoverInstructions = lines[i+ 1].Trim();
                Rover rover = new Rover(
                    int.Parse(RoverInitials.Split(' ')[0]),
                    int.Parse(RoverInitials.Split(' ')[1]),
                     (Heading)System.Enum.Parse(typeof(Heading), RoverInitials.Split(' ')[2].ToUpper().Trim())
                    );

                foreach (char c in RoverInstructions)
                {
                    rover.executeCommand((MovingCommand)System.Enum.Parse(typeof(MovingCommand), c.ToString().ToUpper()));
                    if (rover.currentLocation.x < 0 || rover.currentLocation.x > plateauCoordinate.X
                        || rover.currentLocation.y < 0 || rover.currentLocation.y > plateauCoordinate.Y)
                        throw new System.Exception("Rover has fall out of plateau");
                }
                rovers.Add(rover);
            }
        }
    }
}
