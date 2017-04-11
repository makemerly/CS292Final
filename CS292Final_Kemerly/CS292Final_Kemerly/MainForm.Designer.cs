namespace CS292Final_Kemerly
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecide = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpWhoDecides = new System.Windows.Forms.GroupBox();
            this.radComputer = new System.Windows.Forms.RadioButton();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEndorse = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lstMain = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grpWhoDecides.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDecide
            // 
            this.btnDecide.Location = new System.Drawing.Point(179, 187);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(85, 23);
            this.btnDecide.TabIndex = 1;
            this.btnDecide.Text = "Decide";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(275, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 17);
            this.lblStatus.Text = "  ";
            // 
            // grpWhoDecides
            // 
            this.grpWhoDecides.Controls.Add(this.radComputer);
            this.grpWhoDecides.Controls.Add(this.radUser);
            this.grpWhoDecides.Location = new System.Drawing.Point(12, 187);
            this.grpWhoDecides.Name = "grpWhoDecides";
            this.grpWhoDecides.Size = new System.Drawing.Size(161, 71);
            this.grpWhoDecides.TabIndex = 0;
            this.grpWhoDecides.TabStop = false;
            this.grpWhoDecides.Text = "Who Decides?";
            // 
            // radComputer
            // 
            this.radComputer.AutoSize = true;
            this.radComputer.Checked = true;
            this.radComputer.Location = new System.Drawing.Point(6, 19);
            this.radComputer.Name = "radComputer";
            this.radComputer.Size = new System.Drawing.Size(140, 17);
            this.radComputer.TabIndex = 0;
            this.radComputer.TabStop = true;
            this.radComputer.Text = "The app is The Decider.";
            this.radComputer.UseVisualStyleBackColor = true;
            this.radComputer.CheckedChanged += new System.EventHandler(this.radComputer_CheckedChanged);
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Location = new System.Drawing.Point(6, 42);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(110, 17);
            this.radUser.TabIndex = 1;
            this.radUser.Text = "I am The Decider.";
            this.radUser.UseVisualStyleBackColor = true;
            this.radUser.CheckedChanged += new System.EventHandler(this.radUser_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(179, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEndorse
            // 
            this.btnEndorse.Location = new System.Drawing.Point(179, 216);
            this.btnEndorse.Name = "btnEndorse";
            this.btnEndorse.Size = new System.Drawing.Size(85, 23);
            this.btnEndorse.TabIndex = 2;
            this.btnEndorse.Text = "Endorse/Veto";
            this.btnEndorse.UseVisualStyleBackColor = true;
            this.btnEndorse.Click += new System.EventHandler(this.btnEndorse_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(12, 274);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(85, 23);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lstMain
            // 
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Location = new System.Drawing.Point(12, 12);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(252, 160);
            this.lstMain.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(179, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 331);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnEndorse);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpWhoDecides);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDecide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Decider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpWhoDecides.ResumeLayout(false);
            this.grpWhoDecides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpWhoDecides;
        private System.Windows.Forms.RadioButton radComputer;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEndorse;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.Button btnEdit;
    }
}

