using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Receivers.Base;

namespace Command.Commands.CeilingFanCommands.Base
{
    public abstract class CeilingFanCommand : Command
    {
        protected CeilingFan ceilingFan;
        //protected FanSpeed prevSpeed;

        public CeilingFanCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public override void execute()
        {
            //prevSpeed = ceilingFan.getSpeed();
            prevState = ceilingFan.getState();
        }

        public override void undo()
        {
            switch ((FanSpeed)prevState)
            {
                case FanSpeed.HIGH:
                    ceilingFan.high();
                    break;
                case FanSpeed.MEDIUM:
                    ceilingFan.medium();
                    break;
                case FanSpeed.LOW:
                    ceilingFan.low();
                    break;
                case FanSpeed.OFF:
                    ceilingFan.off();
                    break;
                default:
                    break;
            }
        }
    }
}
