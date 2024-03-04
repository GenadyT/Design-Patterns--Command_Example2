using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Commands.CeilingFanCommands.Base;

namespace Command.Commands.CeilingFanCommands
{
    public class CeilingFanOnMediumCommand : CeilingFanCommand
    {
        public CeilingFanOnMediumCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        public override void execute()
        {
            base.execute();
            ceilingFan.medium();
        }

        public override string ToString()
        {
            return "Command -> 'Ceiling Fan Medium Command'";
        }
    }
}
