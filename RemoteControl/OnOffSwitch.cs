using Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteControl
{
    enum SwitchStatus
    {
        On,
        Off
    }

    public partial class OnOffSwitch : UserControl
    {
        /*private event EventHandler evtOn;
        private event EventHandler evtOff;*/

        private DoIt doItHandler;

        public string Caption
        {
            get { return lblOperation.Text; }
            set { lblOperation.Text = value; }
        }

        private string onCaption;
        private string offCaption;

        private SlotEnum slot;

        public OnOffSwitch()
        {
            InitializeComponent();
        }

        //public void Set(string name, string caption, string onCaption, string offCaption, EventHandler evtOn, EventHandler evtOff)
        //public void Set(string caption, string onCaption, string offCaption, EventHandler evtOn, EventHandler evtOff)
        public void Set(SlotEnum slot, string commandCaption, string onCaption, string offCaption, DoIt doItHandler)
        {
            this.slot = slot;

            btnOn.Text = onCaption;
            this.onCaption = onCaption;

            btnOff.Text = offCaption;
            this.offCaption = offCaption;

            lblStatus.Text = offCaption;
            lblOperation.Text = commandCaption;

            /*this.evtOn = evtOn;
            this.evtOff = evtOff;*/
            this.doItHandler = doItHandler;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            doItHandler?.Invoke(slot, SlotButtonState.On);
            lblStatus.Text = Status(SwitchStatus.On);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            doItHandler?.Invoke(slot, SlotButtonState.Off);
            lblStatus.Text = Status(SwitchStatus.Off);
        }

        private string Status(SwitchStatus swithStatus)
        {
            string strStatus;

            if (swithStatus == SwitchStatus.On)
            {
                strStatus = $"'{onCaption}'";
            }
            else
            {
                strStatus = $"'{offCaption}'";
            }

            return strStatus;
        }
    }
}
