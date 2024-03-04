using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers.Base;

namespace Command.Receivers
{
    public class CeilingFan : Receiver
    {
        private string location;

        public CeilingFan(string location) : base("Living room Ceiling Fan")
        {   
            this.location = location;
        }

        public void low()
        {
            state = (int)FanSpeed.LOW;
            printState();

        }

        public void medium()
        {
            state = (int)FanSpeed.MEDIUM;
            printState();

        }

        public void high()
        {
            state = (int)FanSpeed.HIGH;
            printState();
            
        }

        public void off()
        {
            state = (int)FanSpeed.OFF;
            printState();
        }

        protected override string getStateStr()
        {
            string stateStr;

            switch ((FanSpeed)state)
            {
                case FanSpeed.LOW:
                    stateStr = "LOW";
                    break;
                case FanSpeed.MEDIUM:
                    stateStr = "MEDIUM";
                    break;
                case FanSpeed.HIGH:
                    stateStr = "HIGH";
                    break;
                case FanSpeed.OFF:
                    stateStr = "OFF";
                    break;
                default:
                    stateStr = String.Empty;
                    break;
            }

            return stateStr;
        }

        /*public FanSpeed getSpeed()
        {
            return (FanSpeed)state;
        }*/

        protected override string getAdditionInfo()
        {
            return $"Fan speed: {(FanSpeed)state}";
        }
    }
}
