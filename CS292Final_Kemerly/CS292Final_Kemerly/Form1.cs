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
    public partial class Form1 : Form
    {
        //SQLite Goodness
        private const string dbRestaurants = "Data Source = ../../restaurants.db; version = 3";
        SQLiteConnection conn = new SQLiteConnection(dbRestaurants);
        SQLiteDataAdapter dataAdapter;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();
        string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {

        }

        private void radUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radUser.Checked)
            {
                btnEndorse.Enabled = false;
            }
        }

        private void radComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (radComputer.Checked)
            {
                btnEndorse.Enabled = true;
            }
        }

        private void CategoryList()
        {//holy crap.
            lstMain.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(dbRestaurants))
            {
                conn.Open();
                sql = "SELECT Category FROM Restaurants";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!lstMain.Items.Contains(reader["Category"].ToString()))
                            {
                                lstMain.Items.Add(reader["Category"].ToString());
                            }

                        }
                    }
                }
            }
        }
    }
}
