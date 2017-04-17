namespace CS292Final_Kemerly
{
    partial class History
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.numHistoryVeto = new System.Windows.Forms.NumericUpDown();
            this.chkHistoryVeto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryVeto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(260, 150);
            this.dgvHistory.TabIndex = 0;
            // 
            // numHistoryVeto
            // 
            this.numHistoryVeto.Enabled = false;
            this.numHistoryVeto.Location = new System.Drawing.Point(66, 167);
            this.numHistoryVeto.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHistoryVeto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHistoryVeto.Name = "numHistoryVeto";
            this.numHistoryVeto.Size = new System.Drawing.Size(38, 20);
            this.numHistoryVeto.TabIndex = 1;
            this.numHistoryVeto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkHistoryVeto
            // 
            this.chkHistoryVeto.AutoSize = true;
            this.chkHistoryVeto.Location = new System.Drawing.Point(12, 168);
            this.chkHistoryVeto.Name = "chkHistoryVeto";
            this.chkHistoryVeto.Size = new System.Drawing.Size(48, 17);
            this.chkHistoryVeto.TabIndex = 2;
            this.chkHistoryVeto.Text = "Veto";
            this.chkHistoryVeto.UseVisualStyleBackColor = true;
            this.chkHistoryVeto.CheckedChanged += new System.EventHandler(this.chkHistoryVeto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(110, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "most recent item(s) from history.";
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(197, 226);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 4;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(12, 226);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 5;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(12, 197);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEntry.TabIndex = 6;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHistoryVeto);
            this.Controls.Add(this.numHistoryVeto);
            this.Controls.Add(this.dgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryVeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.NumericUpDown numHistoryVeto;
        private System.Windows.Forms.CheckBox chkHistoryVeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button btnDeleteEntry;
    }
}