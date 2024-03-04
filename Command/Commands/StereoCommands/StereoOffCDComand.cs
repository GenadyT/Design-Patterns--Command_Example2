using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Commands.StereoCommands.Base;

namespace Command.Commands.StereoCommands
{
    public class StereoOffCDComand : StereoPowerComand
    {
        public StereoOffCDComand(RoomStereo stereo) : base(stereo) { }    

        public override void execute()
        {
            base.execute();
            stereo.offCD();
        }

        public override string ToString()
        {
            return "Command -> 'Stereo Power Off CD Command'";
        }
    }
}
