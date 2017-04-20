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
    public partial class Endorse : Form
    {
        public Endorse()
        {
            InitializeComponent();
        }

        private void Endorse_Load(object sender, EventArgs e)
        {
            if (Glb.gDecisionStage <= 1)//Looking to endorse categories.
            {
                foreach (Glb.CatStruct cat in Glb.gCatList)
                {//populating the list
                    lstEndorse.Items.Add("("+cat.weight.ToString("n1") + ") " + cat.category);
                }
            }
            if (Glb.gDecisionStage >= 2)//looking to endorse restaurant
            {
                foreach(Glb.RestStruct rest in Glb.gRestList)
                {//populating the list
                    string endorsement = "";
                    endorsement = "(" + rest.weight.ToString("n1") + ") " + rest.name;
                    if (rest.weight == 0 && Glb.autoVetoEnabled)
                    {
                        endorsement += " (AUTO-VETOED)";
                    }
                    lstEndorse.Items.Add(endorsement);
                }
            }
        }

        private bool selectionExists()
        {
            bool output = false;

            if (lstEndorse.SelectedIndex == -1)
            {
                output = false;
                System.Media.SystemSounds.Beep.Play();
                errProv.SetError(lstEndorse, "Please click an item in the list box.");
            }
            else
            {
                output = true;
            }

            return output;
        }

        private string reString(string input, double weight)
        {//generates a string to replace a line in the listbox
            string output = "";
            string[] temp = input.Split(')');

            output = "(" + weight.ToString("n1") + ")" + temp[1];
            return output;
        }

        private void updateListBox(int inpIndex,string output)
        {
            lstEndorse.Items.RemoveAt(inpIndex);
            lstEndorse.Items.Insert(inpIndex, output);
        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {
            if (!selectionExists())
            {                
                return;
            }
            
            string output;
            double weight = 0;
            int index = lstEndorse.SelectedIndex;

            if (lstEndorse.SelectedItem.ToString().Contains("VETO"))
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Auto-veto settings will override this action.", "Whoops!");
                return;
            }
            if (radW10.Checked)
            {
                weight = 1.0;
            }
            if (radW15.Checked)
            {
                weight = 1.5;
            }
            if (radW20.Checked)
            {
                weight = 2.0;
            }
            if (radW30.Checked)
            {
                weight = 3.0;
            }
            output = reString(lstEndorse.SelectedItem.ToString(), weight);
            updateListBox(index, output);
            lstEndorse.SelectedIndex = index;
        }

        private void btnVeto_Click(object sender, EventArgs e)
        {//i know, i know, identical click events, but i think it makes more sense from a user-experience
            //perspective to have the veto as a separate button.
            if (!selectionExists())
            {
                return;
            }            
            string output;
            double weight = 0;
            int index = lstEndorse.SelectedIndex;
                        
            output = reString(lstEndorse.SelectedItem.ToString(), weight);
            updateListBox(index, output);
            lstEndorse.SelectedIndex = index;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void Endorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            //rekajigger the appropriate global list
            if (Glb.gDecisionStage < 2)
            {
                Glb.gCatList.Clear();
                foreach (string catItem in lstEndorse.Items)
                {
                    string input = catItem.Remove(0, 1);
                    string[] splitStr = input.Split(')');
                    Glb.CatStruct temp;
                    temp.category = splitStr[1].Trim();
                    temp.weight = double.Parse(splitStr[0]);
                    Glb.gCatList.Add(temp);
                }
                Glb.gDecisionStage = 1;
            }
            if (Glb.gDecisionStage >= 2)
            {
                Glb.gRestList.Clear();
                foreach (string restItem in lstEndorse.Items)
                {
                    string input = restItem.Remove(0, 1);
                    string[] splitStr = input.Split(')');
                    Glb.RestStruct temp;
                    temp.name = splitStr[1].Trim();
                    temp.weight = double.Parse(splitStr[0]);
                    Glb.gRestList.Add(temp);
                }
                Glb.gDecisionStage = 3;
            }
        }
    }
}
