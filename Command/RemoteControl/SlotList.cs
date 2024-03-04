using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.RemoteControl
{
    internal class SlotList
    {
        CommandSlot[] list;
        int listCapacity;

        public SlotList(int capacity) 
        {
            list = new CommandSlot[capacity];
            listCapacity = capacity;

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new CommandSlot(new NoCommand(), new NoCommand());
            }
        }

        public bool AddSlot(SlotEnum slot, Command onCommand, Command offCommand)
        {
            return AddSlot(slot, new CommandSlot(onCommand, offCommand));
        }

        public bool AddSlot(SlotEnum slot, CommandSlot cmdSlot)
        {
            //if ((slot < 0) || (slot >= listCapacity))   return false;

            list[(int)slot] = cmdSlot;

            return true;
        }

        public CommandSlot this[int index]
        {
            get { 
                if ((index < 0) || (index >= listCapacity)) return null;

                return list[index];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list.Length; i++)
            {
                sb.AppendLine($"Slot {i+1}: {list[i].ToString()}");
            }

            //return $"Slot List :: \n{sb.ToString()}";
            return $"\n{sb.ToString()}";
        }
    }
}
