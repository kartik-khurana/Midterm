using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }


        // This function gathers all the information from other forms and apply to the read only text boxes
       //used loop
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Statistcs();
            if (raceTextBox.Text == "Human")
            {
                pictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (raceTextBox.Text == "Elf")
            {
                pictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (raceTextBox.Text == "Dwarf")
            {
                pictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if (raceTextBox.Text == "Halfling")
            {
                pictureBox.Image = Properties.Resources.M_Halfling2;
            }
        }

        /// this method sends the message to printer for printing
        
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer For Printing :)");
        }

        /// <summary>
        /// this method helps to exit from the running program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// this method changes the font of the labels and the text box
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
            textBox2.Font = fontDialog.Font;
            textBox3.Font = fontDialog.Font;
            textBox4.Font = fontDialog.Font;
            jobTextBox.Font = fontDialog.Font;
            raceTextBox.Font = fontDialog.Font;
            healthTextBox.Font = fontDialog.Font;
            labelName.Font = fontDialog.Font;
            labelAge.Font = fontDialog.Font;
            labelHeight.Font = fontDialog.Font;
            labelWeight.Font = fontDialog.Font;
            labelJob.Font = fontDialog.Font;
            labelRace.Font = fontDialog.Font;
            labelhealth.Font = fontDialog.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();

            AboutBox.ShowDialog();
        }

        public void Statistcs()
        {
            healthTextBox.Text = Program.random.Health;
            raceTextBox.Text = Program.random.Race;
            jobTextBox.Text = Program.random.Job;
            textBoxStr.Text = Program.random.STR;
            textBoxDex.Text = Program.random.DEX;
            textBoxEnd.Text = Program.random.END;
            textBoxPer.Text = Program.random.INT;
            textBoxInt.Text = Program.random.PER;
            textBoxCha.Text = Program.random.CHA;
        }

    }
}
