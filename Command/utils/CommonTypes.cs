using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public enum SlotButtonState
    {
        // ------
        On,
        Off
        // ------
    }

    public enum OnOffState
    {
        // ------
        On,
        Off
        // ------
    }

    public enum VerticalDoorState
    {
        // -----
        Up,
        Down
        // -----
    }

    public enum SlotEnum
    {
        LiveRoomLight,  //  On/Off
        //-------------------------
        GarageDoor,     //  Up/Down
        //-------------------------
        CeilingFanLowSpeed,
        CeilingFanMediumSpeed,
        CeilingFanHighSpeed,
        //-------------------------
        StereoCD,
        StereoDVD,
        StereoRadio,
    }

    public delegate void DoIt(SlotEnum slot, SlotButtonState buttonState);

    public class CommonTypes
    {
    }
}
