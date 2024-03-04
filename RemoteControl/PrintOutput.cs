using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    public static class PrintDevice
    {
        static TextBox _outputDevice = null;

        public static void SetPrint(TextBox outputDevice) { 
            _outputDevice = outputDevice;

            Command.OutputPrint.PrintDelegate = Print;
            Command.OutputPrint.PrintLineDelegate = PrintLine;
        }

        private static void Print(string printChunk)
        {
            _outputDevice.AppendText(printChunk);
        }
        private static void PrintLine(string printChunk)
        {
            _outputDevice.AppendText($"{printChunk}\n");
            _outputDevice.AppendText(Environment.NewLine);
        }
    }
}
