/* Matt Kemerly
 * Final Project
 * Due 4/26/17
 * Some context on "The Decider":
 * https://www.youtube.com/watch?v=zSF5Epnpkns
 * nsfw-ish: mild language, drunk poorly-animated characters
 */
using System;
using System.Collections.Generic;
using System.Data;
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
        private List<Glb.RestStruct> AutoVetoEnforced(List<Glb.RestStruct> inpList)
        {
            var dumbList = new List<Glb.RestStruct>();

            foreach (Glb.RestStruct rest in inpList)
            {
                var dumbRest = new Glb.RestStruct();
                dumbRest.name = rest.name;
                dumbRest.weight = rest.weight;
                foreach (string veto in Glb.autoVetoList)
                {
                    if (veto == rest.name)
                    {
                        dumbRest.weight = 0.0;
                        break;
                    }
                }
                dumbList.Add(dumbRest);
            }
            return dumbList;
        }

        //private string DateNowToString()
        //{//lol, superfluous effort because sql does that for you
        //    string output = "";
        //    DateTime decisionDate = new DateTime();
        //    int yyyy, mm, dd;

        //    decisionDate = DateTime.Now;
        //    string dateString = decisionDate.ToString();
        //    string[] dateTokens = dateString.Split('/', ' ');
        //    int.TryParse(dateTokens[2], out yyyy);
        //    int.TryParse(dateTokens[0], out mm);
        //    int.TryParse(dateTokens[1], out dd);

        //    output = yyyy.ToString() + "-" + mm.ToString("d2") + "-" + dd.ToString("d2");
        //    return output;
        //}

        private void DateToTable()
        {
            sql = "UPDATE Restaurants "+
                "Set LastVisit = Date() "+
                "WHERE Name = @name";
            conn.Open();
            cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", Glb.gSelectedRestaurant);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        private void btnDecide_Click(object sender, EventArgs e)
        {
            if (radUser.Checked)//manual decision
            {
                if (lstMain.SelectedIndex == -1)
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("You must make a selection from the list to Decide.",
                        "\"That wasn't a decision that was made here.\"");
                    return;
                }

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
            }// end manual decision
            if (radComputer.Checked)//app decides
            {
                if (Glb.gDecisionStage == 0 ||
                    Glb.gDecisionStage == 2)//app needs more info -> btnEndorse
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Click the Endorse/Veto button to set up endorsements and vetoes "
                        + "so The Decider can make an informed Decision.",
                        "\"That wasn't a decision that was made here.\"");
                    return;
                }
                if (Glb.gDecisionStage == 1)
                {//populate weighted list. randomly select index = selected category.
                    double totalweight = 0; //retard testing
                    foreach (Glb.CatStruct cat in Glb.gCatList)
                    {
                        totalweight += cat.weight;
                    }
                    if (totalweight == 0)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        DialogResult whyDammitWhy = MessageBox.Show("All candidate weights are zero. " +
                            "Ignore weights?", "What.", MessageBoxButtons.YesNo);
                        if (whyDammitWhy == DialogResult.Yes)
                        {
                            //convert all weights to 1
                            var dummyList = new List<Glb.CatStruct>();
                            foreach (Glb.CatStruct cat in Glb.gCatList)
                            {
                                var dummyCat = new Glb.CatStruct();
                                dummyCat.category = cat.category;
                                dummyCat.weight = 1;
                                dummyList.Add(dummyCat);
                            }
                            for (int i = 0; i < Glb.gCatList.Count; i++)
                            {
                                Glb.gCatList.RemoveAt(i);
                                Glb.gCatList.Insert(i, dummyList[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Reevaluate your endorsements and vetoes.", "You can fix this.");
                            return;
                        }
                    }
                    Glb.gCatDecisionList = MakeCatDecList(Glb.gCatList);
                    Random randal = new Random();
                    int decisionIndex = randal.Next(0, Glb.gCatDecisionList.Count);
                    Glb.gSelectedCategory = Glb.gCatDecisionList[decisionIndex];
                    //category decision is made
                }// end stage 1
                if (Glb.gDecisionStage == 3)//populate weighted list. random index = selected restaurant.
                {//if auto veto is enabled, enforce it.
                    if (Glb.autoVetoEnabled)
                    {
                        Glb.gRestList = AutoVetoEnforced(Glb.gRestList);
                    }

                    //check for edge case- if all decision candidates have 0 weight, option: ignore or error.
                    double totalWeight = 0;
                    foreach (Glb.RestStruct rest in Glb.gRestList)
                    {
                        totalWeight += rest.weight;
                    }
                    if (totalWeight == 0)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        DialogResult whyDammitWhy = MessageBox.Show("All candidate weights are zero. " +
                            "Ignore weights?", "What.", MessageBoxButtons.YesNo);
                        if (whyDammitWhy == DialogResult.Yes)
                        {
                            //convert all weights to 1
                            var dummyList = new List<Glb.RestStruct>();
                            foreach (Glb.RestStruct rest in Glb.gRestList)
                            {
                                var dummyRest = new Glb.RestStruct();
                                dummyRest.name = rest.name;
                                dummyRest.weight = 1;
                                dummyList.Add(dummyRest);
                            }
                            for (int i = 0; i < Glb.gRestList.Count; i++)
                            {
                                Glb.gRestList.RemoveAt(i);
                                Glb.gRestList.Insert(i, dummyList[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Reevaluate your endorsements and vetoes.", "You can fix this.");
                            return;
                        }
                    }


                    Glb.gRestDecisionList = MakeRestDecList(Glb.gRestList);
                    Random randal = new Random();
                    int decisionIndex = randal.Next(0, Glb.gRestDecisionList.Count);
                    Glb.gSelectedRestaurant = Glb.gRestDecisionList[decisionIndex];
                    //restaurant decision is made                    
                }//end stage 3
            }// end app decides
            
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
                DateToTable();
            }
            if (Glb.gDecisionStage != 0)//really don't want to deal with deleting stuff from the table during process
            {
                btnAddDel.Enabled = false;
            }
        }//end Decide click

        
        private void btnReset_Click(object sender, EventArgs e)
        {//reset the form and all progress
            lblStatus.Text = "";
            Glb.gDecisionStage = 0;
            Glb.gCatList = new List<Glb.CatStruct>();
            Glb.gCatDecisionList = new List<string>();
            Glb.gRestList = new List<Glb.RestStruct>();
            Glb.gRestDecisionList = new List<string>();
            Glb.gSelectedCategory = "";
            Glb.gSelectedRestaurant = "";
            Glb.autoVetoEnabled = false;
            Glb.autoVetoList = new List<string>();
            radComputer.Checked = true;
            btnDecide.Enabled = true;
            btnEndorse.Enabled = true;
            btnAddDel.Enabled = true;
            CategoryListBox();
    }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form frmHistory = new History();
            frmHistory.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frmAddDel = new AddDel();
            frmAddDel.ShowDialog();
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
                    Glb.RestStruct jones;//"...none of this matters." -- carl
                    jones.name = restName;
                    jones.weight = 1;
                    if (Glb.autoVetoEnabled)
                    {
                        foreach (string veto in Glb.autoVetoList)
                        {
                            if (veto == restName)
                            {
                                jones.weight = 0;
                                break;
                            }
                        }
                    }
                    Glb.gRestList.Add(jones);
                }
            }
            //show window
            frmEndorse.ShowDialog();
            //reconstruct lstMain based on decision stage
            lstMain.Items.Clear();

            if (Glb.gDecisionStage != 0)//really don't want to deal with deleting stuff from the table during process
            {
                btnAddDel.Enabled = false;
            }
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
