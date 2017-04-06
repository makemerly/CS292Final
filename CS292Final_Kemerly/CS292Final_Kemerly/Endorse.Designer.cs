namespace CS292Final_Kemerly
{
    partial class Endorse
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
            this.lstEndorse = new System.Windows.Forms.ListBox();
            this.btnEndorse = new System.Windows.Forms.Button();
            this.btnVeto = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.grpWeight = new System.Windows.Forms.GroupBox();
            this.radW15 = new System.Windows.Forms.RadioButton();
            this.radW20 = new System.Windows.Forms.RadioButton();
            this.radW30 = new System.Windows.Forms.RadioButton();
            this.grpWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEndorse
            // 
            this.lstEndorse.FormattingEnabled = true;
            this.lstEndorse.Location = new System.Drawing.Point(12, 12);
            this.lstEndorse.Name = "lstEndorse";
            this.lstEndorse.Size = new System.Drawing.Size(260, 134);
            this.lstEndorse.TabIndex = 0;
            // 
            // btnEndorse
            // 
            this.btnEndorse.Location = new System.Drawing.Point(197, 162);
            this.btnEndorse.Name = "btnEndorse";
            this.btnEndorse.Size = new System.Drawing.Size(75, 23);
            this.btnEndorse.TabIndex = 1;
            this.btnEndorse.Text = "Endorse";
            this.btnEndorse.UseVisualStyleBackColor = true;
            // 
            // btnVeto
            // 
            this.btnVeto.Location = new System.Drawing.Point(197, 191);
            this.btnVeto.Name = "btnVeto";
            this.btnVeto.Size = new System.Drawing.Size(75, 23);
            this.btnVeto.TabIndex = 2;
            this.btnVeto.Text = "Veto";
            this.btnVeto.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(197, 220);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // grpWeight
            // 
            this.grpWeight.Controls.Add(this.radW30);
            this.grpWeight.Controls.Add(this.radW20);
            this.grpWeight.Controls.Add(this.radW15);
            this.grpWeight.Location = new System.Drawing.Point(12, 152);
            this.grpWeight.Name = "grpWeight";
            this.grpWeight.Size = new System.Drawing.Size(125, 91);
            this.grpWeight.TabIndex = 4;
            this.grpWeight.TabStop = false;
            this.grpWeight.Text = "Endorsement Weight";
            // 
            // radW15
            // 
            this.radW15.AutoSize = true;
            this.radW15.Location = new System.Drawing.Point(6, 19);
            this.radW15.Name = "radW15";
            this.radW15.Size = new System.Drawing.Size(40, 17);
            this.radW15.TabIndex = 0;
            this.radW15.TabStop = true;
            this.radW15.Text = "1.5";
            this.radW15.UseVisualStyleBackColor = true;
            // 
            // radW20
            // 
            this.radW20.AutoSize = true;
            this.radW20.Location = new System.Drawing.Point(6, 42);
            this.radW20.Name = "radW20";
            this.radW20.Size = new System.Drawing.Size(40, 17);
            this.radW20.TabIndex = 1;
            this.radW20.TabStop = true;
            this.radW20.Text = "2.0";
            this.radW20.UseVisualStyleBackColor = true;
            // 
            // radW30
            // 
            this.radW30.AutoSize = true;
            this.radW30.Location = new System.Drawing.Point(6, 65);
            this.radW30.Name = "radW30";
            this.radW30.Size = new System.Drawing.Size(40, 17);
            this.radW30.TabIndex = 2;
            this.radW30.TabStop = true;
            this.radW30.Text = "3.0";
            this.radW30.UseVisualStyleBackColor = true;
            // 
            // Endorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpWeight);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnVeto);
            this.Controls.Add(this.btnEndorse);
            this.Controls.Add(this.lstEndorse);
            this.Name = "Endorse";
            this.Text = "Endorse / Veto";
            this.grpWeight.ResumeLayout(false);
            this.grpWeight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEndorse;
        private System.Windows.Forms.Button btnEndorse;
        private System.Windows.Forms.Button btnVeto;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox grpWeight;
        private System.Windows.Forms.RadioButton radW30;
        private System.Windows.Forms.RadioButton radW20;
        private System.Windows.Forms.RadioButton radW15;
    }
}