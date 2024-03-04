using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands.StereoCommands.Base;
using Command.Receivers.Base;

namespace Command.Receivers
{
    public class RoomStereo : OnOffReceiver
    {
        string roomName;

        public RoomStereo(string roomName) : base("Room Stereo")
        {
            this.roomName = roomName;
        }

        public void setCD()
        {
            state = (int)StereoState.CDPowerOn;
            printState();
        }

        public void setDVD()
        {
            state = (int)StereoState.DVDPowerOn;
            printState();
        }

        public void setRadio()
        {
            state = (int)StereoState.RadioPowerOn;
            printState();
        }

        public void offCD()
        {
            state = (int)StereoState.CDPowerOff;
            printState();
        }

        public void offDVD()
        {
            state = (int)StereoState.DVDPowerOff;
            printState();
        }

        public void offRadio()
        {
            state = (int)StereoState.RadioPowerOff;
            printState();
        }

        protected override string getStateStr()
        {
            string stateStr;

            switch ((StereoState)state)
            {
                case StereoState.CDPowerOn:
                    stateStr = "CD Power On";
                    break;
                case StereoState.CDPowerOff:
                    stateStr = "CD Power Off";
                    break;
                case StereoState.DVDPowerOn:
                    stateStr = "DVD Power On";
                    break;
                case StereoState.DVDPowerOff:
                    stateStr = "DVD Power Off";
                    break;
                case StereoState.RadioPowerOn:
                    stateStr = "Radio Power On";
                    break;
                case StereoState.RadioPowerOff:
                    stateStr = "Radio Power Off";
                    break;
                default:
                    stateStr = String.Empty;
                    break;
            }

            return stateStr;
        }

        protected override string getAdditionInfo()
        {
            return $"room name: {roomName}";
        }
    }
}
