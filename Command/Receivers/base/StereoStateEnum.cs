using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands.StereoCommands.Base
{
    // --- the special Enum (not On/Off)
    public enum StereoState
    {
        CDPowerOn,
        CDPowerOff,
        DVDPowerOn,
        DVDPowerOff,
        RadioPowerOn,
        RadioPowerOff
    }
}
