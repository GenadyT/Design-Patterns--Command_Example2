using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Commands.CeilingFanCommands.Base;

namespace Command.Commands.CeilingFanCommands
{
    public class CeilingFanOnHighCommand : CeilingFanCommand
    {
        public CeilingFanOnHighCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void execute()
        {
            base.execute();
            ceilingFan.high();
        }

        public override string ToString()
        {
            return "Command -> 'Ceiling Fan High Command'";
        }
    }
}
