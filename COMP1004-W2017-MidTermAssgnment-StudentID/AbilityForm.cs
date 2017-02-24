using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// Program: Midterm Character Generator
/// Name: Kartik Khurrana
/// StudentID: 200331395
/// App Creation Date: Feb 23, 2017
/// App Desc:Character Generator that generates the first few pages of an RPG character 
/// 


namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class AbilityForm : Form
    {

        // Random Number object
        System.Random random = new System.Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// This method interprets the throwing of a random dice
             
        /// This method returns a number between 3 and 30 (ROLL3D10)

        private int Roll3D10()
        {
         
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }

            return result;
        }


        //Providing values to the text boxes

        private void GeneralAbilities()
        {
            textBoxStr.Text = this.Roll3D10().ToString();
            textBoxDex.Text = this.Roll3D10().ToString();
            textBoxEnd.Text = this.Roll3D10().ToString();
            textBoxInt.Text = this.Roll3D10().ToString();
            textBoxPer.Text = this.Roll3D10().ToString();
            textBoxCha.Text = this.Roll3D10().ToString();
        }


        private void RollButtonClicked(object sender, EventArgs e)
        {
            GeneralAbilities();
            Debug.WriteLine(Roll3D10().ToString());
        }


        //try catch used for validation
        private void NextButtonClicked(object sender, EventArgs e)
        {
            Random random = Program.random;

            try
            {

                random.STR = textBoxStr.Text;
                random.DEX = textBoxDex.Text;
                random.END = textBoxEnd.Text;
                random.INT = textBoxInt.Text;
                random.PER = textBoxPer.Text;
                random.CHA = textBoxCha.Text;

                if (textBoxStr.Text == "")
                {
                    throw new Exception();
                }
                if (textBoxDex.Text == "")
                {
                    throw new Exception();
                }
                if (textBoxEnd.Text == "")
                {
                    throw new Exception();
                }
                if (textBoxInt.Text == "")
                {
                    throw new Exception();
                }
                if (textBoxPer.Text == "")
                {
                    throw new Exception();
                }
                if (textBoxCha.Text == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Roll again as invalid selection has been made");
                return;
            }
            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
