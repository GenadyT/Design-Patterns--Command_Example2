using Command.Commands.StereoCommands.Base;
using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.StereoCommands
{
    internal class StereoSetDVDComand : StereoPowerComand
    {
        public StereoSetDVDComand(RoomStereo stereo) : base(stereo) { }

        public override void execute()
        {
            base.execute();
            stereo.setDVD();
        }

        public override string ToString()
        {
            return "Command -> 'Stereo set DVD Comand'";
        }
    }
}
