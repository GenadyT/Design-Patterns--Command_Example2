using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Receivers.Base;

namespace Command.Commands.GarageCommands.Base
{
    public abstract class GarageDoorComand : Command
    {
        protected GarageDoor garageDoor;

        public GarageDoorComand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public override void execute()
        {
            prevState = garageDoor.getState();
        }

        public override void undo()
        {
            switch (prevState)
            {
                case (int)VerticalDoorState.Up:
                    garageDoor.up();
                    break;
                case (int)VerticalDoorState.Down:
                    garageDoor.down();
                    break;
                default:
                    garageDoor.down();
                    break;
            }
        }
    }
}
