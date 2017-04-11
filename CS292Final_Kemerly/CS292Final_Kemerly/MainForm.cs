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
    public partial class MainForm : Form
    {
        //SQLite Goodness
        private const string dbRestaurants = "Data Source = ../../restaurants.db; version = 3";
        SQLiteConnection conn = new SQLiteConnection(dbRestaurants);
        SQLiteDataAdapter dataAdapter;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();
        string sql;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryListBox();
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            if (radUser.Checked)//manual decision at...
            {
                if (Glb.gDecisionStage == 0)//...category stage.
                {
                    Glb.gSelectedCategory = lstMain.SelectedItem.ToString();
                    RestaurantListBox(Glb.gSelectedCategory);
                    //category decision is made.
                    Glb.gDecisionStage = 2;//skipped stage 1 because manual decision at 0.          
                }
            }
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
            //put each item from listbox into struct, into list.
            if (Glb.gDecisionStage == 0)
            {
                //Category stuff                
                foreach (string restCat in lstMain.Items)
                {
                    Glb.CatStruct smith;//"just say 'smith' or 'jones.' it don't matter."
                    smith.category = restCat;
                    smith.weight = 1;
                    Glb.gCatList.Add(smith);
                }
            }
            else if (Glb.gDecisionStage == 2)
            {
                //Name stuff
                foreach (string restName in lstMain.Items)
                {
                    Glb.RestStruct jones;//"...none of this matters."
                    jones.name = restName;
                    jones.weight = 1;
                    Glb.gRestList.Add(jones);
                }
            }

            Endorse frmEndorse = new Endorse();
            frmEndorse.ShowDialog();
            //lstMain.Items.Clear();

            //foreach ()
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

        private void CategoryListBox()
        {
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
        }//end CategoryListBox

        private void RestaurantListBox(string pSelectedCategory)
        {
            lstMain.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(dbRestaurants))
            {
                conn.Open();
                sql = "SELECT Name FROM Restaurants WHERE Category = " + 
                    "'" + pSelectedCategory + "'";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!lstMain.Items.Contains(reader["Name"].ToString()))
                            {
                                lstMain.Items.Add(reader["Name"].ToString());
                            }

                        }
                    }
                }
            }
        }//end RestaurantListBox
    }
}
