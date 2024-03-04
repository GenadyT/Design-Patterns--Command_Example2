using Command;
using Command.RemoteControl;

namespace RemoteControl
{
    public partial class frmCommandPattern : Form
    {
        Command.Command undoCommand;
        RemoteControlWithUndo remoteControl;

        public frmCommandPattern()
        {
            InitializeComponent();
            PrintDevice.SetPrint(tbxOutputConsole);
            RemoteControlCommandsInit();
        }

        void RemoteControlCommandsInit()
        {
            remoteControl = new RemoteControlWithUndo();
            RemoteControlFiller rcFiller = new RemoteControlFiller();
            rcFiller.Fill(remoteControl);

            void RemoteControlOperate(SlotEnum slot, SlotButtonState buttonState)
            {
                if (buttonState == SlotButtonState.On)
                {
                    remoteControl.OnButtonWasPushed(slot);
                }
                else
                {
                    remoteControl.OffButtonWasPushed(slot);
                }
            }

            // Ceiling Fan
            swtCeilingFanLow.Set(SlotEnum.CeilingFanLowSpeed, "Ceiling Fan Low Speed", "Low Speed", "Off", RemoteControlOperate);
            swtCeilingFanMedium.Set(SlotEnum.CeilingFanMediumSpeed, "Ceiling Fan Medium Speed", "Medium Speed", "Off", RemoteControlOperate);
            swtCeilingFanHigh.Set(SlotEnum.CeilingFanHighSpeed, "Ceiling Fan High Speed", "High Speed", "Off", RemoteControlOperate);

            // Garage Door
            swtGarageDoor.Set(SlotEnum.GarageDoor, "Garage Door", "Up", "Down", RemoteControlOperate);

            // Living Room Light
            swtLivingRoomLight.Set(SlotEnum.LiveRoomLight, "Living Room Light", "On", "Off", RemoteControlOperate);

            // Stereo
            swtStereoCD.Set(SlotEnum.StereoCD, "Stereo CD", "CD", "Off", RemoteControlOperate);
            swtStereoDVD.Set(SlotEnum.StereoDVD, "Stereo DVD", "DVD", "Off", RemoteControlOperate);
            swtStereoRadio.Set(SlotEnum.StereoRadio, "Stereo Radio", "Radio", "Off", RemoteControlOperate);
        }

        private void btnUndoCommand_Click(object sender, EventArgs e)
        {
            remoteControl.CurrentCommand.undo();
        }
    }
}