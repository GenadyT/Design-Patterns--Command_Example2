using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;
using Command.Receivers.Base;

namespace Command.Commands.StereoCommands.Base
{
    public abstract class StereoPowerComand : Command
    {
        protected RoomStereo stereo;

        public StereoPowerComand(RoomStereo stereo)
        {
            this.stereo = stereo;
        }

        public override void execute()
        {
            prevState = stereo.getState();
        }

        public override void undo()
        {
            switch (prevState)
            {
                case (int)StereoState.CDPowerOn:
                    stereo.setCD();
                    break;
                case (int)StereoState.CDPowerOff:
                    stereo.offCD();
                    break;
                case (int)StereoState.DVDPowerOn:
                    stereo.setDVD();
                    break;
                case (int)StereoState.DVDPowerOff:
                    stereo.offDVD();
                    break;
                case (int)StereoState.RadioPowerOn:
                    stereo.setRadio();
                    break;
                case (int)StereoState.RadioPowerOff:
                    stereo.offRadio();
                    break;
                default:
                    break;
            }
        }
    }
}
