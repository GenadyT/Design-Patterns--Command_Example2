using Command.Commands.CeilingFanCommands;
using Command.Commands.CeilingFanCommands.Base;
using Command.Commands.GarageCommands;
using Command.Commands.LightCommands;
using Command.Commands.StereoCommands;
using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.RemoteControl
{
    public class RemoteControlFiller
    {
        public RemoteControlFiller() 
        {   
            
        }

        public void Fill(RemoteControlWithUndo remoteControl) 
        {
            CeilingFanFill(remoteControl);
            LivingRoomLightFill(remoteControl);
            GarageDoorFill(remoteControl);
            StereoFill(remoteControl);

            OutputPrint.Print(remoteControl);
        }

        private void CeilingFanFill(RemoteControlWithUndo remoteControl)
        {
            Command onCommand, offCommand;
            CeilingFan ceilingFan = new CeilingFan("Living Room Ceiling Fan");
            offCommand = new CeilingFanOffCommand(ceilingFan);

            //----- Ceiling Fan Low speed -------------
            onCommand = new CeilingFanOnLowCommand(ceilingFan);
            remoteControl.setCommand(SlotEnum.CeilingFanLowSpeed, onCommand, offCommand);

            //----- Ceiling Fan Medium speed -------------
            onCommand = new CeilingFanOnMediumCommand(ceilingFan);
            remoteControl.setCommand(SlotEnum.CeilingFanMediumSpeed, onCommand, offCommand);

            //----- Ceiling Fan High speed -------------
            onCommand = new CeilingFanOnHighCommand(ceilingFan);
            remoteControl.setCommand(SlotEnum.CeilingFanHighSpeed, onCommand, offCommand);
        }

        private void LivingRoomLightFill(RemoteControlWithUndo remoteControl)
        {
            //----- Living Room -------------
            RoomLight livingRoomLight = new RoomLight("Living Room Light");
            LightOnComand livingRoomLightOn = new LightOnComand(livingRoomLight);
            LightOffComand livingRoomLightOff = new LightOffComand(livingRoomLight);
            remoteControl.setCommand(SlotEnum.LiveRoomLight, livingRoomLightOn, livingRoomLightOff);            

            /*remoteControl.OnButtonWasPushed(slotNumber);
            remoteControl.OffButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);

            remoteControl.undoButtonWasPushed();
            remoteControl.OffButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);

            remoteControl.OnButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);
            remoteControl.undoButtonWasPushed();*/
        }

        private void GarageDoorFill(RemoteControlWithUndo remoteControl)
        {
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorUpComand doorUpComand = new GarageDoorUpComand(garageDoor);
            GarageDoorDownComand doorDownComand = new GarageDoorDownComand(garageDoor);
            remoteControl.setCommand(SlotEnum.GarageDoor, doorUpComand, doorDownComand);
        }

        private void StereoFill(RemoteControlWithUndo remoteControl)
        {
            Command onCommand, offCommand;
            RoomStereo roomStereo = new RoomStereo("Living Room");            

            //----- Stereo CD ----------------
            onCommand = new StereoSetCDComand(roomStereo);
            offCommand = new StereoOffCDComand(roomStereo);
            remoteControl.setCommand(SlotEnum.StereoCD, onCommand, offCommand);

            //----- Stereo DVD ------------------
            onCommand = new StereoSetDVDComand(roomStereo);
            offCommand = new StereoOffDVDComand(roomStereo);
            remoteControl.setCommand(SlotEnum.StereoDVD, onCommand, offCommand);

            //----- Stereo Radio ----------------
            onCommand = new StereoSetRadioComand(roomStereo);
            offCommand = new StereoOffRadioComand(roomStereo);
            remoteControl.setCommand(SlotEnum.StereoRadio, onCommand, offCommand);
        }

        //private static void RemoteLoaderWithGarageDoor()
        //{
        //    RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
        //    GarageDoor garageDoor = new GarageDoor();
        //    /*GarageDoorUpComand doorUpComand = new GarageDoorUpComand(garageDoor);*/
        //    int slotNumber;

        //    slotNumber = 0;
        //    GarageDoorUpComand doorUpComand = new GarageDoorUpComand(garageDoor);
        //    //remoteControl.setCommand(slotNumber, doorUpComand, doorDownComand);
        //    ConsolePrint.Print(remoteControl);

        //    slotNumber = 1;
        //    GarageDoorDownComand doorDownComand = new GarageDoorDownComand(garageDoor);
        //    remoteControl.setCommand(slotNumber, doorUpComand, doorDownComand);
        //    ConsolePrint.Print(remoteControl);

        //}

        //  Fan executes
        //private static void RemoteLoaderWithCeilingFan()
        //{
        //    RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
        //    int slotNumber;
        //    CeilingFan ceilingFan = new CeilingFan("Living Room");
        //    CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

        //    //  בינוי של שלט המרוחק
        //    // -------------------------------------------------------------
        //    slotNumber = 0;
        //    CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
        //    remoteControl.setCommand(slotNumber, ceilingFanLow, ceilingFanOff);

        //    slotNumber = 1;
        //    CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
        //    remoteControl.setCommand(slotNumber, ceilingFanMedium, ceilingFanOff);

        //    slotNumber = 2;
        //    CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
        //    remoteControl.setCommand(slotNumber, ceilingFanHigh, ceilingFanOff);
        //    ConsolePrint.Print(remoteControl);

        //    // הפעלה של שלט המרוחק 
        //    // -------------------------------------------------------------
        //    slotNumber = 0;
        //    remoteControl.OnButtonWasPushed(slotNumber);
        //    remoteControl.OffButtonWasPushed(slotNumber);
        //    ConsolePrint.Print(remoteControl);
        //    remoteControl.undoButtonWasPushed();

        //    slotNumber = 1;
        //    remoteControl.OnButtonWasPushed(slotNumber);
        //    remoteControl.OffButtonWasPushed(slotNumber);
        //    ConsolePrint.Print(remoteControl);
        //    remoteControl.undoButtonWasPushed();

        //    slotNumber = 2;
        //    remoteControl.OnButtonWasPushed(slotNumber);
        //    remoteControl.OffButtonWasPushed(slotNumber);
        //    ConsolePrint.Print(remoteControl);
        //    remoteControl.undoButtonWasPushed();
        //}
    }
}
