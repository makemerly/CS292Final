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
    public partial class MainForm : Form
    {
        //SQLite Goodness
        private const string dbRestaurants = "Data Source = ../../restaurants.db; version = 3";
        SQLiteConnection conn = new SQLiteConnection(dbRestaurants);
        SQLiteDataAdapter da;
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

        private List<string> MakeCatDecList(List<Glb.CatStruct> inpList)
        {//populates a "weighted" list of category entries.
            var outList = new List<string>();

            foreach (Glb.CatStruct catStruct in inpList)
            {
                int maxIndex = (int)(2 * catStruct.weight);
                for (int i = 0; i < maxIndex; i++)
                {
                    outList.Add(catStruct.category);
                }
            }

            return outList;
        }

        private List<string> MakeRestDecList(List<Glb.RestStruct> inpList)
        {//populates a "weighted" list of restaunt names.
            var outList = new List<string>();

            foreach (Glb.RestStruct restStruct in inpList)
            {
                int maxIndex = (int)(2 * restStruct.weight);
                for (int i = 0; i < maxIndex; i++)
                {
                    outList.Add(restStruct.name);
                }
            }

            return outList;
        }
        private void btnDecide_Click(object sender, EventArgs e)
        {
            if (radUser.Checked)//manual decision
            {
                if (Glb.gDecisionStage == 0)//...from a fresh start
                {
                    Glb.gSelectedCategory = lstMain.SelectedItem.ToString();
                    //category decision is made.
                    //lblStatus.Text = "Decision rendered: " + Glb.gSelectedCategory + ".";
                }
                if (Glb.gDecisionStage == 1)//...endorse/veto made, changed mind to decide manually
                {
                    string selection = lstMain.SelectedItem.ToString().Remove(0,1);
                    string[] tokens = selection.Split(')');
                    string category = tokens[1];
                    Glb.gSelectedCategory = category.Trim();
                    //category decision is made.                    
                    //lblStatus.Text = "Decision rendered: " + Glb.gSelectedCategory + ".";
                }
                if (Glb.gDecisionStage == 2)
                {
                    Glb.gSelectedRestaurant = lstMain.SelectedItem.ToString();
                    //restaurant decision is made.
                }
                if (Glb.gDecisionStage == 3)
                {
                    string selection = lstMain.SelectedItem.ToString().Remove(0, 1);
                    string[] tokens = selection.Split(')');
                    string name = tokens[1];
                    Glb.gSelectedRestaurant = name.Trim();
                }
            }
            if (radComputer.Checked)//app decides
            {
                if (Glb.gDecisionStage == 0 ||
                    Glb.gDecisionStage == 2)//app needs more info -> btnEndorse
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Click the Endorse/Veto button to set up endorsements and vetoes "
                        + "so The Decider can make an informed Decision.", "\"You can't just decide.\"");
                    return;
                }
                if (Glb.gDecisionStage == 1)
                {//populate weighted list. randomly select index = selected category.
                    Glb.gCatDecisionList = MakeCatDecList(Glb.gCatList);
                    Random randal = new Random();
                    int decisionIndex = randal.Next(0, Glb.gCatDecisionList.Count);
                    Glb.gSelectedCategory = Glb.gCatDecisionList[decisionIndex];
                    //category decision is made
                    //Glb.gDecisionStage = 2;
                    //lblStatus.Text = "Decision rendered: " + Glb.gSelectedCategory + ".";
                    
                }
                if (Glb.gDecisionStage == 3)
                { //populate weighted list. randomly select index = selected restaurant.
                    Glb.gRestDecisionList = MakeRestDecList(Glb.gRestList);
                    Random randal = new Random();
                    int decisionIndex = randal.Next(0, Glb.gRestDecisionList.Count);
                    Glb.gSelectedRestaurant = Glb.gRestDecisionList[decisionIndex];
                    //restaurant decision is made
                    //Glb.gDecisionStage = 4;
                    //lblStatus.Text = "You will eat at: " + Glb.gSelectedRestaurant + ".";
                    //need to lock out other features now.
                }
            }
            if (Glb.gDecisionStage < 2 && 
                Glb.gSelectedCategory != "")
            {
                lstMain.Items.Clear();
                RestaurantListBox(Glb.gSelectedCategory);
                Glb.gDecisionStage = 2;
                lblStatus.Text = "Category selected: " + Glb.gSelectedCategory + ".";
            }
            if (Glb.gDecisionStage >= 2 &&
                Glb.gSelectedRestaurant != "")
            {
                Glb.gDecisionStage = 4;
                btnDecide.Enabled = false;
                btnEndorse.Enabled = false;
                lblStatus.Text = "You will eat at: " + Glb.gSelectedRestaurant + ".";
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
        {//construct lists from lstMain, open Endorse form, reconstruct lstMain
            Endorse frmEndorse = new Endorse();

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
            //show window
            frmEndorse.ShowDialog();
            //reconstruct lstMain based on decision stage
            lstMain.Items.Clear();
            if (Glb.gDecisionStage < 2)
            {
                foreach (Glb.CatStruct cat in Glb.gCatList)
                {//populating the list
                    lstMain.Items.Add("(" + cat.weight.ToString("n1") + ") " + cat.category);
                }
            }
            if (Glb.gDecisionStage >= 2)
            {
                foreach (Glb.RestStruct rest in Glb.gRestList)
                {//populating the list
                    lstMain.Items.Add("(" + rest.weight.ToString("n1") + ") " + rest.name);
                }
            }
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
