namespace CS292Final_Kemerly
{
    partial class AddDel
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbDelCategory = new System.Windows.Forms.ComboBox();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radDel = new System.Windows.Forms.RadioButton();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.mtxtAddLastVisit = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDelete.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.label2);
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Controls.Add(this.label1);
            this.pnlDelete.Controls.Add(this.cmbName);
            this.pnlDelete.Controls.Add(this.cmbDelCategory);
            this.pnlDelete.Enabled = false;
            this.pnlDelete.Location = new System.Drawing.Point(12, 12);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(260, 181);
            this.pnlDelete.TabIndex = 2;
            this.pnlDelete.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restaurant Name:     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurant Category:     ";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(136, 30);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 1;
            // 
            // cmbDelCategory
            // 
            this.cmbDelCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelCategory.FormattingEnabled = true;
            this.cmbDelCategory.Location = new System.Drawing.Point(136, 3);
            this.cmbDelCategory.Name = "cmbDelCategory";
            this.cmbDelCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbDelCategory.TabIndex = 0;
            this.cmbDelCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(12, 199);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(117, 17);
            this.radAdd.TabIndex = 3;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add Restaurant      ";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // radDel
            // 
            this.radDel.AutoSize = true;
            this.radDel.Location = new System.Drawing.Point(12, 222);
            this.radDel.Name = "radDel";
            this.radDel.Size = new System.Drawing.Size(129, 17);
            this.radDel.TabIndex = 4;
            this.radDel.Text = "Delete Restaurant      ";
            this.radDel.UseVisualStyleBackColor = true;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.mtxtAddLastVisit);
            this.pnlAdd.Controls.Add(this.txtAddName);
            this.pnlAdd.Controls.Add(this.cmbAddCategory);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Location = new System.Drawing.Point(12, 12);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(260, 181);
            this.pnlAdd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restaurant Name:     ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Restaurant Category:     ";
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(136, 3);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbAddCategory.TabIndex = 4;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(136, 30);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(121, 20);
            this.txtAddName.TabIndex = 5;
            // 
            // mtxtAddLastVisit
            // 
            this.mtxtAddLastVisit.Location = new System.Drawing.Point(136, 57);
            this.mtxtAddLastVisit.Mask = "0000/00/00";
            this.mtxtAddLastVisit.Name = "mtxtAddLastVisit";
            this.mtxtAddLastVisit.Size = new System.Drawing.Size(121, 20);
            this.mtxtAddLastVisit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Visit (Optional):     ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(133, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "(YYYY/MM/DD)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.radDel);
            this.Controls.Add(this.radAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddDel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.AddDel_Load);
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.ComboBox cmbDelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radDel;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtAddLastVisit;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.ComboBox cmbAddCategory;
    }
}