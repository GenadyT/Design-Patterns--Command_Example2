using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers.Base
{
    public abstract class OnOffReceiver : Receiver
    {
        public OnOffReceiver(string object_Type) : base(object_Type) { }

        public void on()
        {
            state = (int)OnOffState.On;
            printState();
        }

        public void off()
        {
            state = (int)OnOffState.Off;
            printState();
        }

        protected override string getStateStr()
        {
            string stateStr;

            switch ((OnOffState)state)
            {
                case OnOffState.On:
                    stateStr = "On";
                    break;
                case OnOffState.Off:
                    stateStr = "Off";
                    break;
                default:
                    stateStr = String.Empty;
                    break;
            }

            return stateStr;
        }
    }
}
