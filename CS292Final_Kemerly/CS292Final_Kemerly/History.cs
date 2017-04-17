using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace CS292Final_Kemerly
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        
        //SQLite Goodness
        private const string dbRestaurants = "Data Source = ../../restaurants.db; version = 3";
        SQLiteConnection conn = new SQLiteConnection(dbRestaurants);
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();
        string sql;

        private void DisplayTable()
        {
            sql = "Select * FROM Restaurants";
            ds = new DataSet();
            da = new SQLiteDataAdapter(sql, conn);            
            conn.Open();
            da.Fill(ds);
            conn.Close();
            dgvHistory.DataSource = ds.Tables[0].DefaultView;
            dgvHistory.ClearSelection();            
        }

        private void SortTable()
        {// this is probably stupid. i can probably do this more elgantly with sql commands.
            DataGridViewColumn LastVisit = new DataGridViewColumn();
            LastVisit = dgvHistory.Columns["LastVisit"];
            dgvHistory.Sort(LastVisit, ListSortDirection.Descending);
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
