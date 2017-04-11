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
            this.components = new System.ComponentModel.Container();
            this.lstEndorse = new System.Windows.Forms.ListBox();
            this.btnEndorse = new System.Windows.Forms.Button();
            this.btnVeto = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.grpWeight = new System.Windows.Forms.GroupBox();
            this.radW30 = new System.Windows.Forms.RadioButton();
            this.radW20 = new System.Windows.Forms.RadioButton();
            this.radW15 = new System.Windows.Forms.RadioButton();
            this.radW10 = new System.Windows.Forms.RadioButton();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
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
            this.btnEndorse.Click += new System.EventHandler(this.btnEndorse_Click);
            // 
            // btnVeto
            // 
            this.btnVeto.Location = new System.Drawing.Point(197, 191);
            this.btnVeto.Name = "btnVeto";
            this.btnVeto.Size = new System.Drawing.Size(75, 23);
            this.btnVeto.TabIndex = 2;
            this.btnVeto.Text = "Veto";
            this.btnVeto.UseVisualStyleBackColor = true;
            this.btnVeto.Click += new System.EventHandler(this.btnVeto_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(197, 220);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // grpWeight
            // 
            this.grpWeight.Controls.Add(this.radW10);
            this.grpWeight.Controls.Add(this.radW30);
            this.grpWeight.Controls.Add(this.radW20);
            this.grpWeight.Controls.Add(this.radW15);
            this.grpWeight.Location = new System.Drawing.Point(12, 162);
            this.grpWeight.Name = "grpWeight";
            this.grpWeight.Size = new System.Drawing.Size(125, 62);
            this.grpWeight.TabIndex = 4;
            this.grpWeight.TabStop = false;
            this.grpWeight.Text = "Endorsement Weight";
            // 
            // radW30
            // 
            this.radW30.AutoSize = true;
            this.radW30.Location = new System.Drawing.Point(52, 42);
            this.radW30.Name = "radW30";
            this.radW30.Size = new System.Drawing.Size(40, 17);
            this.radW30.TabIndex = 2;
            this.radW30.Text = "3.0";
            this.radW30.UseVisualStyleBackColor = true;
            // 
            // radW20
            // 
            this.radW20.AutoSize = true;
            this.radW20.Location = new System.Drawing.Point(52, 19);
            this.radW20.Name = "radW20";
            this.radW20.Size = new System.Drawing.Size(40, 17);
            this.radW20.TabIndex = 1;
            this.radW20.Text = "2.0";
            this.radW20.UseVisualStyleBackColor = true;
            // 
            // radW15
            // 
            this.radW15.AutoSize = true;
            this.radW15.Location = new System.Drawing.Point(6, 42);
            this.radW15.Name = "radW15";
            this.radW15.Size = new System.Drawing.Size(40, 17);
            this.radW15.TabIndex = 0;
            this.radW15.Text = "1.5";
            this.radW15.UseVisualStyleBackColor = true;
            // 
            // radW10
            // 
            this.radW10.AutoSize = true;
            this.radW10.Checked = true;
            this.radW10.Location = new System.Drawing.Point(6, 19);
            this.radW10.Name = "radW10";
            this.radW10.Size = new System.Drawing.Size(40, 17);
            this.radW10.TabIndex = 5;
            this.radW10.TabStop = true;
            this.radW10.Text = "1.0";
            this.radW10.UseVisualStyleBackColor = true;
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Endorse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Endorse / Veto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Endorse_FormClosing);
            this.Load += new System.EventHandler(this.Endorse_Load);
            this.grpWeight.ResumeLayout(false);
            this.grpWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
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
        private System.Windows.Forms.RadioButton radW10;
        private System.Windows.Forms.ErrorProvider errProv;
    }
}