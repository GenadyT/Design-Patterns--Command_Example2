using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Commands.GarageCommands.Base;

namespace Command.Commands.GarageCommands
{
    public class GarageDoorDownComand : GarageDoorComand
    {
        public GarageDoorDownComand(GarageDoor garageDoor) : base(garageDoor) { }

        public override void execute()
        {
            base.execute();
            garageDoor.down();
        }

        public override string ToString()
        {
            return "Command -> 'Garage Door Down Comand'";
        }
    }
}
