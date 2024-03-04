using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Commands.GarageCommands.Base;

namespace Command.Commands.GarageCommands
{
    public class GarageDoorUpComand : GarageDoorComand
    {
        public GarageDoorUpComand(GarageDoor garageDoor) : base(garageDoor) { }

        public override void execute()
        {
            garageDoor.up();
        }

        public override string ToString()
        {
            return "Command -> 'Garage Door Up Comand'";
        }
    }
}
