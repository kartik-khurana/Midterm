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
    public partial class JobForm : Form
    {
        private string _jobSelected;
        public RaceForm previousForm;

        private int _soldierHealthScore = 30;
        private int _rogueHealthScore = 28;
        private int _magickerHealthScore = 15;
        private int _cultistHealthScore = 24;


        private int _DexHealthMod = Convert.ToInt32(Program.random.DEX);
        private int _EndHealthMod = Convert.ToInt32(Program.random.END);
        private int _IntHealthMod = Convert.ToInt32(Program.random.INT);
        private int _ChaHealthMod = Convert.ToInt32(Program.random.CHA);



        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Random random = Program.random;

            random.Health = healthPointTextBox.Text;
            random.Job = _jobSelected;
            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }

        private void SoldierRadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_soldierHealthScore + _EndHealthMod).ToString();
        }

        private void RogueRadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_rogueHealthScore + _DexHealthMod).ToString();
        }

        private void MagickerRadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_magickerHealthScore + _IntHealthMod).ToString();
        }

        private void CultistRadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_cultistHealthScore + _ChaHealthMod).ToString();
        }

       
    }
}
