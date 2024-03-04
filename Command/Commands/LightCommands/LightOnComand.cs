using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands.LightCommands
{
    public class LightOnComand : LightComand
    {
        public LightOnComand(RoomLight light) : base(light) { }

        public override void execute()
        {
            light.on();
        }

        public override void undo()
        {
            light.off();
        }

        public override string ToString()
        {
            return "Command -> 'Light On Comand'";
        }
    }
}
