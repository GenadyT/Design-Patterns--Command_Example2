using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers.Base;

namespace Command.Receivers
{
    public class RoomLight : OnOffReceiver
    {        
        string roomName;

        public RoomLight(string roomName) : base("Room Light")
        {   
            this.roomName = roomName;
        }

        protected override string getAdditionInfo()
        {
            return $"room name: {roomName}";
        }
    }
}
