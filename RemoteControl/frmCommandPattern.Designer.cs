using System.Windows.Forms;

namespace RemoteControl
{
    partial class frmCommandPattern
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbRemoteControl = new GroupBox();
            gpbGarageDoor = new GroupBox();
            swtGarageDoor = new OnOffSwitch();
            btnUndoCommand = new Button();
            gpbStereo = new GroupBox();
            swtStereoCD = new OnOffSwitch();
            gpbLivingRoomLight = new GroupBox();
            swtLivingRoomLight = new OnOffSwitch();
            gpbCeilingFan = new GroupBox();
            swtCeilingFanHigh = new OnOffSwitch();
            swtCeilingFanMedium = new OnOffSwitch();
            swtCeilingFanLow = new OnOffSwitch();
            tbxOutputConsole = new TextBox();
            gpbOutput = new GroupBox();
            swtStereoDVD = new OnOffSwitch();
            swtStereoRadio = new OnOffSwitch();
            gpbRemoteControl.SuspendLayout();
            gpbGarageDoor.SuspendLayout();
            gpbStereo.SuspendLayout();
            gpbLivingRoomLight.SuspendLayout();
            gpbCeilingFan.SuspendLayout();
            gpbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // gpbRemoteControl
            // 
            gpbRemoteControl.BackColor = Color.SteelBlue;
            gpbRemoteControl.Controls.Add(gpbGarageDoor);
            gpbRemoteControl.Controls.Add(btnUndoCommand);
            gpbRemoteControl.Controls.Add(gpbStereo);
            gpbRemoteControl.Controls.Add(gpbLivingRoomLight);
            gpbRemoteControl.Controls.Add(gpbCeilingFan);
            gpbRemoteControl.Location = new Point(12, 12);
            gpbRemoteControl.Name = "gpbRemoteControl";
            gpbRemoteControl.Size = new Size(497, 713);
            gpbRemoteControl.TabIndex = 0;
            gpbRemoteControl.TabStop = false;
            gpbRemoteControl.Text = "Remote Control";
            // 
            // gpbGarageDoor
            // 
            gpbGarageDoor.BackColor = SystemColors.ActiveCaption;
            gpbGarageDoor.Controls.Add(swtGarageDoor);
            gpbGarageDoor.Location = new Point(17, 26);
            gpbGarageDoor.Name = "gpbGarageDoor";
            gpbGarageDoor.Size = new Size(467, 87);
            gpbGarageDoor.TabIndex = 5;
            gpbGarageDoor.TabStop = false;
            gpbGarageDoor.Text = "Garage Door";
            // 
            // swtGarageDoor
            // 
            swtGarageDoor.BackColor = Color.White;
            swtGarageDoor.BorderStyle = BorderStyle.FixedSingle;
            swtGarageDoor.Caption = "Operation";
            swtGarageDoor.Location = new Point(14, 22);
            swtGarageDoor.Name = "swtGarageDoor";
            swtGarageDoor.Size = new Size(438, 50);
            swtGarageDoor.TabIndex = 0;
            // 
            // btnUndoCommand
            // 
            btnUndoCommand.Location = new Point(181, 671);
            btnUndoCommand.Name = "btnUndoCommand";
            btnUndoCommand.Size = new Size(77, 26);
            btnUndoCommand.TabIndex = 4;
            btnUndoCommand.Text = "Undo";
            btnUndoCommand.UseVisualStyleBackColor = true;
            btnUndoCommand.Click += btnUndoCommand_Click;
            // 
            // gpbStereo
            // 
            gpbStereo.BackColor = SystemColors.ActiveCaption;
            gpbStereo.Controls.Add(swtStereoRadio);
            gpbStereo.Controls.Add(swtStereoDVD);
            gpbStereo.Controls.Add(swtStereoCD);
            gpbStereo.Location = new Point(17, 451);
            gpbStereo.Name = "gpbStereo";
            gpbStereo.Size = new Size(467, 198);
            gpbStereo.TabIndex = 3;
            gpbStereo.TabStop = false;
            gpbStereo.Text = "Stereo";
            // 
            // swtStereoCD
            // 
            swtStereoCD.BackColor = Color.White;
            swtStereoCD.BorderStyle = BorderStyle.FixedSingle;
            swtStereoCD.Caption = "Operation";
            swtStereoCD.Location = new Point(15, 22);
            swtStereoCD.Name = "swtStereoCD";
            swtStereoCD.Size = new Size(438, 50);
            swtStereoCD.TabIndex = 0;
            // 
            // gpbLivingRoomLight
            // 
            gpbLivingRoomLight.BackColor = SystemColors.ActiveCaption;
            gpbLivingRoomLight.Controls.Add(swtLivingRoomLight);
            gpbLivingRoomLight.Location = new Point(17, 129);
            gpbLivingRoomLight.Name = "gpbLivingRoomLight";
            gpbLivingRoomLight.Size = new Size(467, 87);
            gpbLivingRoomLight.TabIndex = 2;
            gpbLivingRoomLight.TabStop = false;
            gpbLivingRoomLight.Text = "Living Room Light";
            // 
            // swtLivingRoomLight
            // 
            swtLivingRoomLight.BackColor = Color.White;
            swtLivingRoomLight.BorderStyle = BorderStyle.FixedSingle;
            swtLivingRoomLight.Caption = "Operation";
            swtLivingRoomLight.Location = new Point(15, 25);
            swtLivingRoomLight.Name = "swtLivingRoomLight";
            swtLivingRoomLight.Size = new Size(438, 50);
            swtLivingRoomLight.TabIndex = 0;
            // 
            // gpbCeilingFan
            // 
            gpbCeilingFan.BackColor = SystemColors.ActiveCaption;
            gpbCeilingFan.Controls.Add(swtCeilingFanHigh);
            gpbCeilingFan.Controls.Add(swtCeilingFanMedium);
            gpbCeilingFan.Controls.Add(swtCeilingFanLow);
            gpbCeilingFan.Location = new Point(17, 234);
            gpbCeilingFan.Name = "gpbCeilingFan";
            gpbCeilingFan.Size = new Size(467, 198);
            gpbCeilingFan.TabIndex = 0;
            gpbCeilingFan.TabStop = false;
            gpbCeilingFan.Text = "Ceiling Fan";
            // 
            // swtCeilingFanHigh
            // 
            swtCeilingFanHigh.BackColor = Color.White;
            swtCeilingFanHigh.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanHigh.Caption = "Operation";
            swtCeilingFanHigh.Location = new Point(15, 138);
            swtCeilingFanHigh.Name = "swtCeilingFanHigh";
            swtCeilingFanHigh.Size = new Size(438, 50);
            swtCeilingFanHigh.TabIndex = 2;
            // 
            // swtCeilingFanMedium
            // 
            swtCeilingFanMedium.BackColor = Color.White;
            swtCeilingFanMedium.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanMedium.Caption = "Operation";
            swtCeilingFanMedium.Location = new Point(15, 82);
            swtCeilingFanMedium.Name = "swtCeilingFanMedium";
            swtCeilingFanMedium.Size = new Size(438, 50);
            swtCeilingFanMedium.TabIndex = 1;
            // 
            // swtCeilingFanLow
            // 
            swtCeilingFanLow.BackColor = Color.White;
            swtCeilingFanLow.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanLow.Caption = "Operation";
            swtCeilingFanLow.Location = new Point(15, 24);
            swtCeilingFanLow.Name = "swtCeilingFanLow";
            swtCeilingFanLow.Size = new Size(438, 50);
            swtCeilingFanLow.TabIndex = 0;
            // 
            // tbxOutputConsole
            // 
            tbxOutputConsole.BackColor = SystemColors.ActiveBorder;
            tbxOutputConsole.BorderStyle = BorderStyle.None;
            tbxOutputConsole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxOutputConsole.Location = new Point(19, 22);
            tbxOutputConsole.Multiline = true;
            tbxOutputConsole.Name = "tbxOutputConsole";
            tbxOutputConsole.ScrollBars = ScrollBars.Both;
            tbxOutputConsole.Size = new Size(756, 671);
            tbxOutputConsole.TabIndex = 1;
            // 
            // gpbOutput
            // 
            gpbOutput.BackColor = Color.FromArgb(128, 64, 64);
            gpbOutput.Controls.Add(tbxOutputConsole);
            gpbOutput.Location = new Point(524, 12);
            gpbOutput.Name = "gpbOutput";
            gpbOutput.Size = new Size(762, 713);
            gpbOutput.TabIndex = 2;
            gpbOutput.TabStop = false;
            gpbOutput.Text = "Output";
            // 
            // swtStereoDVD
            // 
            swtStereoDVD.BackColor = Color.White;
            swtStereoDVD.BorderStyle = BorderStyle.FixedSingle;
            swtStereoDVD.Caption = "Operation";
            swtStereoDVD.Location = new Point(14, 78);
            swtStereoDVD.Name = "swtStereoDVD";
            swtStereoDVD.Size = new Size(438, 50);
            swtStereoDVD.TabIndex = 1;
            // 
            // swtStereoRadio
            // 
            swtStereoRadio.BackColor = Color.White;
            swtStereoRadio.BorderStyle = BorderStyle.FixedSingle;
            swtStereoRadio.Caption = "Operation";
            swtStereoRadio.Location = new Point(14, 134);
            swtStereoRadio.Name = "swtStereoRadio";
            swtStereoRadio.Size = new Size(438, 50);
            swtStereoRadio.TabIndex = 2;
            // 
            // frmCommandPattern
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1299, 745);
            Controls.Add(gpbOutput);
            Controls.Add(gpbRemoteControl);
            Name = "frmCommandPattern";
            Text = "Command Pattern";
            gpbRemoteControl.ResumeLayout(false);
            gpbGarageDoor.ResumeLayout(false);
            gpbStereo.ResumeLayout(false);
            gpbLivingRoomLight.ResumeLayout(false);
            gpbCeilingFan.ResumeLayout(false);
            gpbOutput.ResumeLayout(false);
            gpbOutput.PerformLayout();
            ResumeLayout(false);
        }

        private void InitializeComponent_Copy()
        {
            gpbRemoteControl = new GroupBox();
            gpbStereo = new GroupBox();
            gpbLivingRoomLight = new GroupBox();
            swtLivingRoomLight = new OnOffSwitch();
            gpbCeilingFan = new GroupBox();
            swtCeilingFanLow = new OnOffSwitch();
            tbxOutputConsole = new TextBox();
            gpbOutput = new GroupBox();
            swtCeilingFanMedium = new OnOffSwitch();
            swtCeilingFanHigh = new OnOffSwitch();
            gpbRemoteControl.SuspendLayout();
            gpbLivingRoomLight.SuspendLayout();
            gpbCeilingFan.SuspendLayout();
            gpbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // gpbRemoteControl
            // 
            gpbRemoteControl.BackColor = Color.SteelBlue;
            gpbRemoteControl.Controls.Add(gpbStereo);
            gpbRemoteControl.Controls.Add(gpbLivingRoomLight);
            gpbRemoteControl.Controls.Add(gpbCeilingFan);
            gpbRemoteControl.Location = new Point(12, 12);
            gpbRemoteControl.Name = "gpbRemoteControl";
            gpbRemoteControl.Size = new Size(465, 713);
            gpbRemoteControl.TabIndex = 0;
            gpbRemoteControl.TabStop = false;
            gpbRemoteControl.Text = "Remote Control";
            // 
            // gpbStereo
            // 
            gpbStereo.BackColor = SystemColors.ActiveCaption;
            gpbStereo.Location = new Point(16, 452);
            gpbStereo.Name = "gpbStereo";
            gpbStereo.Size = new Size(420, 84);
            gpbStereo.TabIndex = 3;
            gpbStereo.TabStop = false;
            gpbStereo.Text = "Stereo";
            // 
            // gpbLivingRoomLight
            // 
            gpbLivingRoomLight.BackColor = SystemColors.ActiveCaption;
            gpbLivingRoomLight.Controls.Add(swtLivingRoomLight);
            gpbLivingRoomLight.Location = new Point(16, 253);
            gpbLivingRoomLight.Name = "gpbLivingRoomLight";
            gpbLivingRoomLight.Size = new Size(429, 87);
            gpbLivingRoomLight.TabIndex = 2;
            gpbLivingRoomLight.TabStop = false;
            gpbLivingRoomLight.Text = "Living Room Light";
            // 
            // swtLivingRoomLight
            // 
            swtLivingRoomLight.BackColor = Color.White;
            swtLivingRoomLight.BorderStyle = BorderStyle.FixedSingle;
            swtLivingRoomLight.Caption = "Operation";
            swtLivingRoomLight.Location = new Point(15, 25);
            swtLivingRoomLight.Name = "swtLivingRoomLight";
            swtLivingRoomLight.Size = new Size(397, 50);
            swtLivingRoomLight.TabIndex = 0;
            // 
            // gpbCeilingFan
            // 
            gpbCeilingFan.BackColor = SystemColors.ActiveCaption;
            gpbCeilingFan.Controls.Add(swtCeilingFanHigh);
            gpbCeilingFan.Controls.Add(swtCeilingFanMedium);
            gpbCeilingFan.Controls.Add(swtCeilingFanLow);
            gpbCeilingFan.Location = new Point(16, 34);
            gpbCeilingFan.Name = "gpbCeilingFan";
            gpbCeilingFan.Size = new Size(429, 198);
            gpbCeilingFan.TabIndex = 0;
            gpbCeilingFan.TabStop = false;
            gpbCeilingFan.Text = "Ceiling Fan";
            // 
            // swtCeilingFanLow
            // 
            swtCeilingFanLow.BackColor = Color.White;
            swtCeilingFanLow.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanLow.Caption = "Operation";
            swtCeilingFanLow.Location = new Point(15, 24);
            swtCeilingFanLow.Name = "swtCeilingFanLow";
            swtCeilingFanLow.Size = new Size(397, 50);
            swtCeilingFanLow.TabIndex = 0;
            // 
            // tbxOutputConsole
            // 
            tbxOutputConsole.BackColor = Color.FromArgb(110, 110, 110);
            tbxOutputConsole.BorderStyle = BorderStyle.None;
            tbxOutputConsole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbxOutputConsole.Location = new Point(19, 22);
            tbxOutputConsole.Multiline = true;
            tbxOutputConsole.Name = "tbxOutputConsole";
            tbxOutputConsole.ScrollBars = ScrollBars.Both;
            tbxOutputConsole.Size = new Size(756, 671);
            tbxOutputConsole.TabIndex = 1;
            // 
            // gpbOutput
            // 
            gpbOutput.BackColor = Color.FromArgb(128, 64, 64);
            gpbOutput.Controls.Add(tbxOutputConsole);
            gpbOutput.Location = new Point(493, 12);
            gpbOutput.Name = "gpbOutput";
            gpbOutput.Size = new Size(794, 713);
            gpbOutput.TabIndex = 2;
            gpbOutput.TabStop = false;
            gpbOutput.Text = "Output";
            // 
            // swtCeilingFanMedium
            // 
            swtCeilingFanMedium.BackColor = Color.White;
            swtCeilingFanMedium.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanMedium.Caption = "Operation";
            swtCeilingFanMedium.Location = new Point(15, 82);
            swtCeilingFanMedium.Name = "swtCeilingFanMedium";
            swtCeilingFanMedium.Size = new Size(397, 50);
            swtCeilingFanMedium.TabIndex = 1;
            // 
            // swtCeilingFanHigh
            // 
            swtCeilingFanHigh.BackColor = Color.White;
            swtCeilingFanHigh.BorderStyle = BorderStyle.FixedSingle;
            swtCeilingFanHigh.Caption = "Operation";
            swtCeilingFanHigh.Location = new Point(15, 138);
            swtCeilingFanHigh.Name = "swtCeilingFanHigh";
            swtCeilingFanHigh.Size = new Size(397, 50);
            swtCeilingFanHigh.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1299, 745);
            Controls.Add(gpbOutput);
            Controls.Add(gpbRemoteControl);
            Name = "Form1";
            Text = "Command Pattern";
            gpbRemoteControl.ResumeLayout(false);
            gpbLivingRoomLight.ResumeLayout(false);
            gpbCeilingFan.ResumeLayout(false);
            gpbOutput.ResumeLayout(false);
            gpbOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbRemoteControl;
        private GroupBox gpbCeilingFan;
        //private OnOffSwitch swtLowSpeed;
        private TextBox tbxOutputConsole;
        //private OnOffSwitch swtHighSpeed;
        //private OnOffSwitch swtMediumSpeed;
        private GroupBox gpbGarage;
        //private OnOffSwitch swtDoorDown;
        //private OnOffSwitch swtDoorUp;
        private GroupBox gpbStereo;
        //private OnOffSwitch swtStereoOff;
        //private OnOffSwitch swtStereoOn;
        private GroupBox gpbLivingRoomLight;
        //private OnOffSwitch swtLightOff;
        //private OnOffSwitch swtLightOn;
        private GroupBox gpbOutput;
        private OnOffSwitch swtLivingRoomLight;
        private OnOffSwitch swtCeilingFanLow;
        private OnOffSwitch swtCeilingFanHigh;
        private OnOffSwitch swtCeilingFanMedium;
        private Button btnUndoCommand;
        private GroupBox gpbGarageDoor;
        private OnOffSwitch swtGarageDoor;
        private OnOffSwitch swtStereoCD;
        private OnOffSwitch swtStereoRadio;
        private OnOffSwitch swtStereoDVD;
    }
}