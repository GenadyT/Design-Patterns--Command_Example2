using Command.Commands.StereoCommands.Base;
using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.StereoCommands
{
    internal class StereoSetRadioComand : StereoPowerComand
    {
        public StereoSetRadioComand(RoomStereo stereo) : base(stereo) { }

        public override void execute()
        {
            base.execute();
            stereo.setRadio();
        }

        public override string ToString()
        {
            return "Command -> 'Stereo set Radio Comand'";
        }
    }
}
