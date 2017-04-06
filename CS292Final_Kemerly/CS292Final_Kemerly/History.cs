using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS292Final_Kemerly
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void chkHistoryVeto_CheckedChanged(object sender, EventArgs e)
        {
            numHistoryVeto.Enabled = chkHistoryVeto.Checked;
            label1.Enabled = chkHistoryVeto.Checked;
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
