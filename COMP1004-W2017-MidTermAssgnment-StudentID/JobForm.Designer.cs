namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.groupBoxJob = new System.Windows.Forms.GroupBox();
            this.radioButtonCultist = new System.Windows.Forms.RadioButton();
            this.radioButtonMagicker = new System.Windows.Forms.RadioButton();
            this.radioButtonRouge = new System.Windows.Forms.RadioButton();
            this.radioButtonSoldier = new System.Windows.Forms.RadioButton();
            this.labelHealthPoints = new System.Windows.Forms.Label();
            this.healthPointTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NextButton.Location = new System.Drawing.Point(260, 450);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // groupBoxJob
            // 
            this.groupBoxJob.Controls.Add(this.radioButtonCultist);
            this.groupBoxJob.Controls.Add(this.radioButtonMagicker);
            this.groupBoxJob.Controls.Add(this.radioButtonRouge);
            this.groupBoxJob.Controls.Add(this.radioButtonSoldier);
            this.groupBoxJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxJob.Location = new System.Drawing.Point(34, 55);
            this.groupBoxJob.Name = "groupBoxJob";
            this.groupBoxJob.Size = new System.Drawing.Size(202, 237);
            this.groupBoxJob.TabIndex = 4;
            this.groupBoxJob.TabStop = false;
            this.groupBoxJob.Text = "Job";
            // 
            // radioButtonCultist
            // 
            this.radioButtonCultist.AutoSize = true;
            this.radioButtonCultist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonCultist.Location = new System.Drawing.Point(7, 189);
            this.radioButtonCultist.Name = "radioButtonCultist";
            this.radioButtonCultist.Size = new System.Drawing.Size(77, 28);
            this.radioButtonCultist.TabIndex = 3;
            this.radioButtonCultist.Text = "Cultist";
            this.radioButtonCultist.UseVisualStyleBackColor = true;
            this.radioButtonCultist.CheckedChanged += new System.EventHandler(this.CultistRadioButtonChecked);
            // 
            // radioButtonMagicker
            // 
            this.radioButtonMagicker.AutoSize = true;
            this.radioButtonMagicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonMagicker.Location = new System.Drawing.Point(6, 136);
            this.radioButtonMagicker.Name = "radioButtonMagicker";
            this.radioButtonMagicker.Size = new System.Drawing.Size(105, 28);
            this.radioButtonMagicker.TabIndex = 2;
            this.radioButtonMagicker.Text = "Magicker";
            this.radioButtonMagicker.UseVisualStyleBackColor = true;
            this.radioButtonMagicker.CheckedChanged += new System.EventHandler(this.MagickerRadioButtonChecked);
            // 
            // radioButtonRouge
            // 
            this.radioButtonRouge.AutoSize = true;
            this.radioButtonRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonRouge.Location = new System.Drawing.Point(7, 83);
            this.radioButtonRouge.Name = "radioButtonRouge";
            this.radioButtonRouge.Size = new System.Drawing.Size(85, 28);
            this.radioButtonRouge.TabIndex = 1;
            this.radioButtonRouge.Text = "Rogue";
            this.radioButtonRouge.UseVisualStyleBackColor = true;
            this.radioButtonRouge.CheckedChanged += new System.EventHandler(this.RogueRadioButtonChecked);
            // 
            // radioButtonSoldier
            // 
            this.radioButtonSoldier.AutoSize = true;
            this.radioButtonSoldier.Checked = true;
            this.radioButtonSoldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSoldier.Location = new System.Drawing.Point(7, 32);
            this.radioButtonSoldier.Name = "radioButtonSoldier";
            this.radioButtonSoldier.Size = new System.Drawing.Size(87, 28);
            this.radioButtonSoldier.TabIndex = 0;
            this.radioButtonSoldier.TabStop = true;
            this.radioButtonSoldier.Text = "Soldier";
            this.radioButtonSoldier.UseVisualStyleBackColor = true;
            this.radioButtonSoldier.CheckedChanged += new System.EventHandler(this.SoldierRadioButtonChecked);
            // 
            // labelHealthPoints
            // 
            this.labelHealthPoints.AutoSize = true;
            this.labelHealthPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthPoints.Location = new System.Drawing.Point(289, 138);
            this.labelHealthPoints.Name = "labelHealthPoints";
            this.labelHealthPoints.Size = new System.Drawing.Size(104, 20);
            this.labelHealthPoints.TabIndex = 5;
            this.labelHealthPoints.Text = "Health Points";
            // 
            // healthPointTextBox
            // 
            this.healthPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.healthPointTextBox.Location = new System.Drawing.Point(293, 176);
            this.healthPointTextBox.Name = "healthPointTextBox";
            this.healthPointTextBox.Size = new System.Drawing.Size(319, 26);
            this.healthPointTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthPointTextBox);
            this.Controls.Add(this.labelHealthPoints);
            this.Controls.Add(this.groupBoxJob);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.groupBoxJob.ResumeLayout(false);
            this.groupBoxJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox groupBoxJob;
        private System.Windows.Forms.RadioButton radioButtonCultist;
        private System.Windows.Forms.RadioButton radioButtonMagicker;
        private System.Windows.Forms.RadioButton radioButtonRouge;
        private System.Windows.Forms.RadioButton radioButtonSoldier;
        private System.Windows.Forms.Label labelHealthPoints;
        private System.Windows.Forms.TextBox healthPointTextBox;
    }
}