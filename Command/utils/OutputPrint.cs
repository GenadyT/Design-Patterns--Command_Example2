using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Command
{   
    public static class OutputPrint
    {
        private static Action<string> printDelegate;
        public static Action<string> PrintDelegate {  set { printDelegate = value; } }

        private static Action<string> printLineDelegate;
        public static Action<string> PrintLineDelegate { set { printLineDelegate = value; } }

        //public static void Print(string printStr, bool withAfterSpace = false)
        public static void Print(string printStr)
        {            
            //if (withAfterSpace)
            
            printDelegate(printStr);
        }
        //public static void Print(IStringable obj, bool withAfterSpace = true)
        public static void Print(object obj)
        {
            //Print(obj.ToString(), withAfterSpace);
            Print(obj.ToString());
        }

        public static void PrintLine(string printStr)
        {
            //if (withAfterSpace)

            printLineDelegate(printStr);
        }
        //public static void Print(IStringable obj, bool withAfterSpace = true)
        public static void PrintLine(object obj)
        {   
            PrintLine(obj.ToString());
        }
    }
}
