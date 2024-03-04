using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers.Base
{
    public abstract class Receiver
    {
        protected const string Base_Type = "Receiver";
        protected string Object_Type;
        protected string objectInfo;

        protected int state;        

        public Receiver(string object_Type)
        {
            Object_Type = object_Type;
            state = 0;
        }

        protected abstract string getAdditionInfo();
        //protected abstract string getState();

        public int getState()
        {
            return state;
        }

        protected abstract string getStateStr();

        protected void printState()
        {
            string objectTitle = $"The {Base_Type} is - {Object_Type}";
            string objectState = getStateStr();
            string additionInfo = getAdditionInfo();
            //string sStatus = this.isOn ? "On" : "Off";
            OutputPrint.PrintLine($"{objectTitle}  /  {additionInfo}  /  the state is - {objectState}");
        }
    }
}
