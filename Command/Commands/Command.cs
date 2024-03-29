﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class Command
    {
        protected const string Object_Type = "Command";

        protected int prevState;

        public abstract void execute();

        public abstract void undo();
    }
}
