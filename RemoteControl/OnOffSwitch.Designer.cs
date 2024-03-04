namespace RemoteControl
{
    public partial class OnOffSwitch
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOn = new Button();
            btnOff = new Button();
            lblOperation = new Label();
            lblDelim = new Label();
            lblStatus = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOn
            // 
            btnOn.BackColor = Color.LightGray;
            btnOn.Location = new Point(288, 13);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(65, 23);
            btnOn.TabIndex = 0;
            btnOn.Text = "On";
            btnOn.UseVisualStyleBackColor = false;
            btnOn.Click += btnOn_Click;
            // 
            // btnOff
            // 
            btnOff.BackColor = Color.LightGray;
            btnOff.Location = new Point(359, 13);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(65, 23);
            btnOff.TabIndex = 1;
            btnOff.Text = "Off";
            btnOff.UseVisualStyleBackColor = false;
            btnOff.Click += btnOff_Click;
            // 
            // lblOperation
            // 
            lblOperation.BackColor = Color.PowderBlue;
            lblOperation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperation.Location = new Point(15, 13);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(157, 23);
            lblOperation.TabIndex = 2;
            lblOperation.Text = "Operation";
            // 
            // lblDelim
            // 
            lblDelim.AutoSize = true;
            lblDelim.Location = new Point(271, 17);
            lblDelim.Name = "lblDelim";
            lblDelim.Size = new Size(10, 15);
            lblDelim.TabIndex = 3;
            lblDelim.Text = "|";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.MistyRose;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(198, 13);
            lblStatus.Margin = new Padding(2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 16);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 5;
            label2.Text = "--";
            // 
            // OnOffSwitch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(lblDelim);
            Controls.Add(lblOperation);
            Controls.Add(btnOff);
            Controls.Add(btnOn);
            Name = "OnOffSwitch";
            Size = new Size(438, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOn;
        private Button btnOff;
        private Label lblOperation;
        private Label lblDelim;
        private Label lblStatus;
        private Label label2;
    }
}
