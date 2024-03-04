using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands.LightCommands
{
    public class LightOffComand : LightComand
    {
        public LightOffComand(RoomLight light) : base(light) { }

        public override void execute()
        {
            light.off();
        }

        public override string ToString()
        {
            return "Command -> 'Light Off Comand'";
        }
    }
}
