using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class NoCommand : Command
    {
        public NoCommand()
        {
            
        }

        public override void execute()
        {
            OutputPrint.Print("NoCommand execute");
        }

        public override void undo()
        {
            OutputPrint.Print("NoCommand undo");
        }

        public override string ToString()
        {
            return "Command -> 'NoCommand'";
        }
    }
}