using Command.Commands.StereoCommands.Base;
using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.StereoCommands
{
    internal class StereoOffRadioComand : StereoPowerComand
    {
        public StereoOffRadioComand(RoomStereo stereo) : base(stereo) { }

        public override void execute()
        {
            base.execute();
            stereo.offRadio();
        }

        public override string ToString()
        {
            return "Command -> 'Stereo Power Off Radio Command'";
        }
    }
}
