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
            if (Globals.gDecisionStage <= 1)//Looking to endorse categories.
            {
                foreach (Globals.CatStruct cat in Globals.gCatList)
                {//populating the list
                    lstEndorse.Items.Add("("+cat.weight.ToString("n1") + ") " + cat.category);
                }
            }
        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {
            if (lstEndorse.SelectedIndex == -1)
            {
                System.Media.SystemSounds.Beep.Play();
                errProv.SetError(lstEndorse, "Please click an item in the list box.");
                return;
            }

            string selection = lstEndorse.SelectedItem.ToString().Remove(0,1);
            string[] splitStr = selection.Split(')');
            string output;
            double weight = double.Parse(splitStr[0]);
            int index = lstEndorse.SelectedIndex;
                        
            if (radW10.Checked && weight != 1.0)
            {
                weight = 1.0;
            }
            if (radW15.Checked && weight != 1.5)
            {
                weight = 1.5;
            }
            if (radW20.Checked && weight != 2.0)
            {
                weight = 2.0;
            }
            if (radW30.Checked && weight != 3.0)
            {
                weight = 3.0;
            }
            output = "(" + weight.ToString("n1") + ")" + splitStr[1];
            lstEndorse.Items.RemoveAt(index);
            lstEndorse.Items.Insert(index, output);
        }

        private void btnVeto_Click(object sender, EventArgs e)
        {//i know, i know, identical click events, but i think it makes more sense from a user-experience
            //perspective to have the veto as a separate button.
            if (lstEndorse.SelectedIndex == -1)
            {
                System.Media.SystemSounds.Beep.Play();
                errProv.SetError(lstEndorse, "Please click an item in the list box.");
                return;
            }

            string selection = lstEndorse.SelectedItem.ToString().Remove(0, 1);
            string[] splitStr = selection.Split(')');
            string output;
            double weight = 0;
            int index = lstEndorse.SelectedIndex;

            output = "(" + weight.ToString("n1") + ")" + splitStr[1];
            lstEndorse.Items.RemoveAt(index);
            lstEndorse.Items.Insert(index, output);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void Endorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            //rekajigger the appropriate lists
            if (Globals.gDecisionStage < 2)
            {
                Globals.gCatList.Clear();
                foreach (string catItem in lstEndorse.Items)
                {
                    string input = catItem.Remove(0, 1);
                    string[] splitStr = input.Split(')');
                    Globals.CatStruct temp;
                    temp.category = splitStr[1].Trim();
                    temp.weight = double.Parse(splitStr[0]);
                    Globals.gCatList.Add(temp);
                }
                Globals.gDecisionStage = 1;
            }
            
        }
    }
}
