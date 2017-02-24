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
    public partial class RaceForm : Form
    {
        public AbilityForm previousForm;      
        private string _raceSelected;        //instance variables

        private int _StrMod = Convert.ToInt32(Program.random.STR);
        private int _DexMod = Convert.ToInt32(Program.random.DEX);
        private int _EndMod = Convert.ToInt32(Program.random.END);
        private int _IntMod = Convert.ToInt32(Program.random.INT);
        private int _PerMod = Convert.ToInt32(Program.random.PER);
        private int _ChaMod = Convert.ToInt32(Program.random.CHA);


        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            Random random = Program.random;

            random.Race = _raceSelected;


            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        private void HumanRadioButtonChecked(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.M_Human1;
            RadioButton selectedRace = (RadioButton)sender;

            textBoxRacial.Text = "Increase all abilities by 5";

            _StrMod = _StrMod + 5;
            _DexMod = _DexMod + 5;
            _EndMod = _EndMod + 5;
            _IntMod = _IntMod + 5;
            _PerMod = _PerMod + 5;
            _ChaMod = _ChaMod + 5;


            this._raceSelected = selectedRace.Text;
        }

        private void ElfRadioButtonChecked(object sender, EventArgs e)
        {

            pictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton selectedRace = (RadioButton)sender;
            textBoxRacial.Text = "Increase DEX and CHA by 15";

            _DexMod = _DexMod + 15;
            _ChaMod = _ChaMod + 15;

            this._raceSelected = selectedRace.Text;

        }

        private void DwarfRadioButtonChecked(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.M_Dwarf1;
            RadioButton selectedRace = (RadioButton)sender;
            textBoxRacial.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _StrMod = _StrMod + 20;
            _PerMod = _PerMod + 20;
            _ChaMod = _ChaMod - 10;
            this._raceSelected = selectedRace.Text;

        }

        private void HalflingRadioButtonChecked(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.M_Halfling2;
            RadioButton selectedRace = (RadioButton)sender;

            textBoxRacial.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DexMod = _DexMod + 20;
            _IntMod = _IntMod + 20;
            _StrMod = _StrMod - 10;

            this._raceSelected = selectedRace.Text;

        }

        private void textBoxRacial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
