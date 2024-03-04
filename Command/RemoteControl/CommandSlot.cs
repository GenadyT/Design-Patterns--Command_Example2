using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.RemoteControl
{
    internal class CommandSlot
    {
        Command onCommand;
        public Command OnCommand { get { return onCommand; } }

        Command offCommand;
        public Command OffCommand { get { return offCommand; } }

        public CommandSlot(Command onCommand, Command offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }

        public override string ToString()
        {
            string sOnCommand = onCommand.ToString();
            string sOffCommand = offCommand.ToString();

            return $"Command Slot => \n   OnCommand: {sOnCommand}, OffCommand: {sOffCommand}";
        }
    }
}
