using Command.RemoteControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.RemoteControl
{
    public class RemoteControlWithUndo
    {
        /*Command[] onCommands;
        Command[] offCommands;*/
        Command currentCommand;
        public Command CurrentCommand {  get { return currentCommand; } }

        SlotList slotList;

        public RemoteControlWithUndo() 
        {
            Command noCommand = new NoCommand();

            Array slotEntries = Enum.GetValues(typeof(SlotEnum));
            slotList = new SlotList(slotEntries.Length);

            foreach (SlotEnum entry in slotEntries)
            {
                slotList.AddSlot(entry, noCommand, noCommand);
            }

            currentCommand = noCommand;
        }

        public void setCommand(SlotEnum slot, Command onCommand, Command offCommand)
        {
            //if ((slot < 0) || ( slot >= SlotCount))   throw new ArgumentOutOfRangeException();

            /*onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;*/

            slotList.AddSlot(slot, onCommand, offCommand);
        }

        public void OnButtonWasPushed(SlotEnum slot)
        {
            Command command = slotList[(int)slot].OnCommand;
            command.execute();
            currentCommand = command;
        }

        public void OffButtonWasPushed(SlotEnum slot)
        {
            Command command = slotList[(int)slot].OffCommand;
            command.execute();
            currentCommand = command;
        }

        public void undoButtonWasPushed()
        {
            OutputPrint.Print("undo Button Was Pushed");
            currentCommand.undo();
        }

        public override string ToString()
        {
            StringBuilder stringBld = new StringBuilder();

            stringBld.AppendLine("******************************************************");
            stringBld.AppendLine("--------- Remote Control Commands ---------");
            stringBld.AppendLine("Slot List:");
            stringBld.AppendLine("----------");
            stringBld.AppendLine(slotList.ToString());
            stringBld.AppendLine("******************************************************");

            return stringBld.ToString();
        }
    }
}
