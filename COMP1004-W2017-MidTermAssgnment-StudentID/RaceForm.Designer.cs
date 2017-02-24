namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class RaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.labelRacial = new System.Windows.Forms.Label();
            this.textBoxRacial = new System.Windows.Forms.TextBox();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            this.halflingRadioButton = new System.Windows.Forms.RadioButton();
            this.dwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.elfRadioButton = new System.Windows.Forms.RadioButton();
            this.humanRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(450, 424);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 28);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClicked);
            // 
            // labelRacial
            // 
            this.labelRacial.AutoSize = true;
            this.labelRacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRacial.Location = new System.Drawing.Point(27, 345);
            this.labelRacial.Name = "labelRacial";
            this.labelRacial.Size = new System.Drawing.Size(115, 20);
            this.labelRacial.TabIndex = 6;
            this.labelRacial.Text = "Racial Bonus";
            // 
            // textBoxRacial
            // 
            this.textBoxRacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRacial.Location = new System.Drawing.Point(31, 383);
            this.textBoxRacial.Name = "textBoxRacial";
            this.textBoxRacial.Size = new System.Drawing.Size(433, 29);
            this.textBoxRacial.TabIndex = 7;
            this.textBoxRacial.TextChanged += new System.EventHandler(this.textBoxRacial_TextChanged);
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Controls.Add(this.halflingRadioButton);
            this.groupBoxCharacter.Controls.Add(this.dwarfRadioButton);
            this.groupBoxCharacter.Controls.Add(this.elfRadioButton);
            this.groupBoxCharacter.Controls.Add(this.humanRadioButton);
            this.groupBoxCharacter.Location = new System.Drawing.Point(31, 46);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Size = new System.Drawing.Size(150, 203);
            this.groupBoxCharacter.TabIndex = 8;
            this.groupBoxCharacter.TabStop = false;
            this.groupBoxCharacter.Text = "Character\'s Race";
            // 
            // halflingRadioButton
            // 
            this.halflingRadioButton.AutoSize = true;
            this.halflingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halflingRadioButton.Location = new System.Drawing.Point(7, 167);
            this.halflingRadioButton.Name = "halflingRadioButton";
            this.halflingRadioButton.Size = new System.Drawing.Size(90, 28);
            this.halflingRadioButton.TabIndex = 3;
            this.halflingRadioButton.Text = "Halfling";
            this.halflingRadioButton.UseVisualStyleBackColor = true;
            this.halflingRadioButton.CheckedChanged += new System.EventHandler(this.HalflingRadioButtonChecked);
            // 
            // dwarfRadioButton
            // 
            this.dwarfRadioButton.AutoSize = true;
            this.dwarfRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwarfRadioButton.Location = new System.Drawing.Point(6, 120);
            this.dwarfRadioButton.Name = "dwarfRadioButton";
            this.dwarfRadioButton.Size = new System.Drawing.Size(75, 28);
            this.dwarfRadioButton.TabIndex = 2;
            this.dwarfRadioButton.Text = "Dwarf";
            this.dwarfRadioButton.UseVisualStyleBackColor = true;
            this.dwarfRadioButton.CheckedChanged += new System.EventHandler(this.DwarfRadioButtonChecked);
            // 
            // elfRadioButton
            // 
            this.elfRadioButton.AutoSize = true;
            this.elfRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elfRadioButton.Location = new System.Drawing.Point(7, 77);
            this.elfRadioButton.Name = "elfRadioButton";
            this.elfRadioButton.Size = new System.Drawing.Size(49, 28);
            this.elfRadioButton.TabIndex = 1;
            this.elfRadioButton.Text = "Elf";
            this.elfRadioButton.UseVisualStyleBackColor = true;
            this.elfRadioButton.CheckedChanged += new System.EventHandler(this.ElfRadioButtonChecked);
            // 
            // humanRadioButton
            // 
            this.humanRadioButton.AutoSize = true;
            this.humanRadioButton.Checked = true;
            this.humanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanRadioButton.Location = new System.Drawing.Point(6, 34);
            this.humanRadioButton.Name = "humanRadioButton";
            this.humanRadioButton.Size = new System.Drawing.Size(90, 28);
            this.humanRadioButton.TabIndex = 0;
            this.humanRadioButton.TabStop = true;
            this.humanRadioButton.Text = "Human";
            this.humanRadioButton.UseVisualStyleBackColor = true;
            this.humanRadioButton.CheckedChanged += new System.EventHandler(this.HumanRadioButtonChecked);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_StudentID.Properties.Resources.M_Human1;
            this.pictureBox.Location = new System.Drawing.Point(260, 57);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(290, 262);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(570, 465);
            this.Controls.Add(this.groupBoxCharacter);
            this.Controls.Add(this.textBoxRacial);
            this.Controls.Add(this.labelRacial);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox;
        internal System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label labelRacial;
        private System.Windows.Forms.TextBox textBoxRacial;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
        private System.Windows.Forms.RadioButton halflingRadioButton;
        private System.Windows.Forms.RadioButton dwarfRadioButton;
        private System.Windows.Forms.RadioButton elfRadioButton;
        private System.Windows.Forms.RadioButton humanRadioButton;
    }
}