using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Receivers.Base;

namespace Command.Commands.LightCommands
{
    public abstract class LightComand : Command
    {
        protected RoomLight light;

        public LightComand(RoomLight light)
        {
            this.light = light;
        }
        public override void undo()
        {
            switch (prevState)
            {
                case (int)OnOffState.On:
                    light.on();
                    break;
                case (int)OnOffState.Off:
                    light.off();
                    break;
                default:
                    light.off();
                    break;
            }
        }
    }
}
