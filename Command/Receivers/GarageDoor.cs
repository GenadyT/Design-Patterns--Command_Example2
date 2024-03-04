using Command.Receivers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class GarageDoor : Receiver
    {
        public GarageDoor() : base("Garage Door") { }

        public void up()
        {
            state = (int)VerticalDoorState.Up;
            printState();
        }

        public void down()
        {
            state = (int)VerticalDoorState.Down;
            printState();
        }

        protected override string getStateStr()
        {
            string stateStr;

            switch ((VerticalDoorState)state)
            {
                case VerticalDoorState.Up:
                    stateStr = "Up";
                    break;
                case VerticalDoorState.Down:
                    stateStr = "Down";
                    break;
                default:
                    stateStr = String.Empty;
                    break;
            }

            return stateStr;
        }

        protected override string getAdditionInfo()
        {
            return $"the our house garage";
        }
    }
}
