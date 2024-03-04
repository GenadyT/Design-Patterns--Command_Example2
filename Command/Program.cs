using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands.GarageCommands;
using Command.Commands.CeilingFanCommands;
using Command.Commands.LightCommands;
using Command.RemoteControl;
using Command.Receivers;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoteLoader();
            //RemoteLoaderUndoButtonQA();

            //RemoteLoaderWithCeilingFan();
            //RemoteLoaderWithGarageDoor();
        }

        //  Garage Door executes
        

        

        /*private static void RemoteLoaderUndoButtonQA()
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
            int slotNumber;

            //----- Living Room -------------
            slotNumber = 0;
            Light livingRoomLight = new Light("Living Room");
            LightOnComand livingRoomLightOn = new LightOnComand(livingRoomLight);
            LightOffComand livingRoomLightOff = new LightOffComand(livingRoomLight);
            remoteControl.setCommand(slotNumber, livingRoomLightOn, livingRoomLightOff);
            ConsolePrint.Print(remoteControl);

            remoteControl.OnButtonWasPushed(slotNumber);
            remoteControl.OffButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);

            remoteControl.undoButtonWasPushed();
            remoteControl.OffButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);

            remoteControl.OnButtonWasPushed(slotNumber);
            ConsolePrint.Print(remoteControl);
            remoteControl.undoButtonWasPushed();
        }*/

        /*private static void RemoteLoader()
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
            int slotNumber;

            //----- Living Room -------------
            slotNumber = 0;
            Light livingRoomLight = new Light("Living Room");
            LightOnComand livingRoomLightOn = new LightOnComand(livingRoomLight);
            LightOffComand livingRoomLightOff = new LightOffComand(livingRoomLight);
            remoteControl.setCommand(slotNumber, livingRoomLightOn, livingRoomLightOff);
            remoteControl.onButtonWasPushed(slotNumber);
            remoteControl.offButtonWasPushed(slotNumber);

            //----- Ceiling Fan -------------
            slotNumber = 2;
            CeilingFan ceilingFan = new CeilingFan("Ceiling Fan");
            CeilingFanOnComand ceilingFanOn = new CeilingFanOnComand(ceilingFan);
            CeilingFanHighComand ceilingFanOff = new CeilingFanHighComand(ceilingFan);
            remoteControl.setCommand(slotNumber, ceilingFanOn, ceilingFanOff);
            remoteControl.onButtonWasPushed(slotNumber);
            remoteControl.offButtonWasPushed(slotNumber);

            //----- Garage Door -------------
            slotNumber = 3;
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorUpComand garageDoorUp = new GarageDoorUpComand(garageDoor);
            GarageDoorDownComand garageDoorDown = new GarageDoorDownComand(garageDoor);
            remoteControl.setCommand(slotNumber, garageDoorUp, garageDoorDown);
            remoteControl.onButtonWasPushed(slotNumber);
            remoteControl.offButtonWasPushed(slotNumber);

            //----- Garage Door -------------
            slotNumber = 4;
            Stereo stereo = new Stereo("Living Room");
            StereoPowerOnComand stereoPowerOn = new StereoPowerOnComand(stereo);
            StereoPowerOffComand stereoPowerOff = new StereoPowerOffComand(stereo);
            remoteControl.setCommand(slotNumber, stereoPowerOn, stereoPowerOff);
            remoteControl.onButtonWasPushed(slotNumber);
            remoteControl.offButtonWasPushed(slotNumber);

            //------ bdika NoCommand ----------
            slotNumber = 6;
            remoteControl.onButtonWasPushed(slotNumber);
            remoteControl.offButtonWasPushed(slotNumber);
        }*/
    }
}
