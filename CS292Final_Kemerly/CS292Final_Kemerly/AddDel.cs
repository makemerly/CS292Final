﻿using System;
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
    public partial class AddDel : Form
    {
        //SQLite Goodness
        private const string dbRestaurants = "Data Source = ../../restaurants.db; version = 3";
        SQLiteConnection conn = new SQLiteConnection(dbRestaurants);
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();
        string sql;

        public AddDel()
        {
            InitializeComponent();
        }

        private void GetCategories(ComboBox inpCombo)
        {
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
                            if (!inpCombo.Items.Contains(reader["Category"].ToString()))
                            {
                                inpCombo.Items.Add(reader["Category"].ToString());
                            }

                        }
                    }
                }
            }
        }// end GetCategories

        private void GetNames()
        {
            cmbName.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(dbRestaurants))
            {
                conn.Open();
                sql = "SELECT Name FROM Restaurants WHERE Category = " +
                    "'" + cmbDelCategory.SelectedItem + "'";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!cmbName.Items.Contains(reader["Name"].ToString()))
                            {
                                cmbName.Items.Add(reader["Name"].ToString());
                            }

                        }
                    }
                }
            }
        }//end GetNames

        private void DelRestaurant()
        {
            sql = "DELETE FROM Restaurants WHERE Name = @name";
            conn.Open();
            cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", cmbName.SelectedItem);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private bool GoodCombo(ComboBox inpCombo)
        {   
            if (inpCombo.SelectedIndex == -1)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Make a selection from the "+ inpCombo.Tag + ".",
                    "Whoa there.");
                return false;
            }
            return true;
        }

        private void AddRestaurant(string name, string category, string date)
        {
            sql = "INSERT INTO Restaurants(Name, Category, LastVisit) " + 
                "VALUES(@name, @category, @lastvisit)";
            conn.Open();
            cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@category", category);
            if (date != "")
            {
                cmd.Parameters.AddWithValue("@lastvisit", date);
            }
            else
            {
                cmd.Parameters.AddWithValue("@lastvisit", null);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void AddDel_Load(object sender, EventArgs e)
        {
            GetCategories(cmbAddCategory);
            GetCategories(cmbDelCategory);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNames();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!GoodCombo(cmbName))
            {                
                return;
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                DialogResult whyDammitWhy = MessageBox.Show("Permanently remove " +
                           cmbName.SelectedItem + "from the collection?",
                           "Whoa, there.", MessageBoxButtons.YesNo);
                if (whyDammitWhy == DialogResult.Yes)
                {
                    DelRestaurant();
                }
                else
                {
                    return;
                }
            }
            GetNames();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            cmbAddCategory.SelectedIndex = -1;
            cmbDelCategory.SelectedIndex = -1;
            
            if (radAdd.Checked)
            {
                pnlDelete.Enabled = false;
                pnlDelete.Visible = false;
                //pnlAdd.Enabled = true;
                //pnlAdd.Visible = true;
            }
            else
            {
                pnlDelete.Enabled = true;
                pnlDelete.Visible = true;
                //pnlAdd.Enabled = false;
                //pnlAdd.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = "";
            string category = "";
            string[] wipDate;
            string date;
            int yyyy = 0 , mm = 0, dd = 0;
            bool dateNull = false;

            if (!GoodCombo(cmbAddCategory))
            {
                return;
            }
            if (txtAddName.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("You must enter a Restaurant Name to add a record.", "Whoa, there.");
                return;
            }
            wipDate = mtxtAddLastVisit.Text.Split('/');
            if (!int.TryParse(wipDate[0], out yyyy) ||
                !int.TryParse(wipDate[1], out mm) ||
                !int.TryParse(wipDate[2], out dd))
            {
                System.Media.SystemSounds.Beep.Play();
                DialogResult whyDammitWhy = MessageBox.Show("Invalid Last Visit date. " +
                    "Skip date entry for this record?",
                           "Whoa, there.", MessageBoxButtons.YesNo);
                if (whyDammitWhy == DialogResult.Yes)
                {
                    dateNull = true;
                }
                else //if dialogresult == no
                {
                    return;
                }
            }
            category = cmbAddCategory.SelectedItem.ToString();
            name = txtAddName.Text;
            if (!dateNull)
            { date = yyyy.ToString() + "/" + mm.ToString("d2") + "/" + dd.ToString("d2"); }
            else
            { date = null; }
            try
            {
                AddRestaurant(name, category, date);
            }
            catch
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("There was an error adding the entry to the collection.",
                    "Whoa, there.");
                return;
            }
            
        }//end add click
    }
}