﻿namespace IRF_Project_Work
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainLabel = new System.Windows.Forms.Label();
            this.radioBtn_ID = new System.Windows.Forms.RadioButton();
            this.radioBtn_Coord = new System.Windows.Forms.RadioButton();
            this.radioBtn_Name = new System.Windows.Forms.RadioButton();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Coord = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btn_GO = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.engFlag_TBox = new System.Windows.Forms.CheckBox();
            this.gerFlag_TBox = new System.Windows.Forms.CheckBox();
            this.hunLang_TBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainLabel.Location = new System.Drawing.Point(36, 28);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(198, 25);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Keresett város adata:";
            this.MainLabel.UseMnemonic = false;
            // 
            // radioBtn_ID
            // 
            this.radioBtn_ID.AutoSize = true;
            this.radioBtn_ID.Location = new System.Drawing.Point(41, 80);
            this.radioBtn_ID.Name = "radioBtn_ID";
            this.radioBtn_ID.Size = new System.Drawing.Size(36, 17);
            this.radioBtn_ID.TabIndex = 1;
            this.radioBtn_ID.TabStop = true;
            this.radioBtn_ID.Text = "ID";
            this.radioBtn_ID.UseVisualStyleBackColor = true;
            this.radioBtn_ID.CheckedChanged += new System.EventHandler(this.radioBtn_ID_CheckedChanged);
            // 
            // radioBtn_Coord
            // 
            this.radioBtn_Coord.AutoSize = true;
            this.radioBtn_Coord.Location = new System.Drawing.Point(41, 113);
            this.radioBtn_Coord.Name = "radioBtn_Coord";
            this.radioBtn_Coord.Size = new System.Drawing.Size(79, 17);
            this.radioBtn_Coord.TabIndex = 2;
            this.radioBtn_Coord.TabStop = true;
            this.radioBtn_Coord.Text = "Koordináta:";
            this.radioBtn_Coord.UseVisualStyleBackColor = true;
            this.radioBtn_Coord.CheckedChanged += new System.EventHandler(this.radioBtn_Coord_CheckedChanged);
            // 
            // radioBtn_Name
            // 
            this.radioBtn_Name.AutoSize = true;
            this.radioBtn_Name.Location = new System.Drawing.Point(41, 147);
            this.radioBtn_Name.Name = "radioBtn_Name";
            this.radioBtn_Name.Size = new System.Drawing.Size(45, 17);
            this.radioBtn_Name.TabIndex = 3;
            this.radioBtn_Name.TabStop = true;
            this.radioBtn_Name.Text = "Név";
            this.radioBtn_Name.UseVisualStyleBackColor = true;
            this.radioBtn_Name.CheckedChanged += new System.EventHandler(this.radioBtn_Name_CheckedChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(134, 80);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 4;
            // 
            // textBox_Coord
            // 
            this.textBox_Coord.Location = new System.Drawing.Point(134, 112);
            this.textBox_Coord.Name = "textBox_Coord";
            this.textBox_Coord.Size = new System.Drawing.Size(100, 20);
            this.textBox_Coord.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(134, 147);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 6;
            // 
            // btn_GO
            // 
            this.btn_GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_GO.Location = new System.Drawing.Point(694, 390);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(75, 48);
            this.btn_GO.TabIndex = 7;
            this.btn_GO.Text = "Go";
            this.btn_GO.UseVisualStyleBackColor = true;
            this.btn_GO.Click += new System.EventHandler(this.btn_GO_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.languageLabel.Location = new System.Drawing.Point(541, 28);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(182, 25);
            this.languageLabel.TabIndex = 8;
            this.languageLabel.Text = "Lekérdezés nyelve:";
            this.languageLabel.UseMnemonic = false;
            // 
            // engFlag_TBox
            // 
            this.engFlag_TBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.engFlag_TBox.BackgroundImage = global::IRF_Project_Work.Properties.Resources.usFlag;
            this.engFlag_TBox.Checked = true;
            this.engFlag_TBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.engFlag_TBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.engFlag_TBox.FlatAppearance.BorderSize = 4;
            this.engFlag_TBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.engFlag_TBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.engFlag_TBox.Location = new System.Drawing.Point(660, 88);
            this.engFlag_TBox.Name = "engFlag_TBox";
            this.engFlag_TBox.Size = new System.Drawing.Size(63, 44);
            this.engFlag_TBox.TabIndex = 11;
            this.engFlag_TBox.UseVisualStyleBackColor = true;
            this.engFlag_TBox.CheckedChanged += new System.EventHandler(this.engFlag_TBox_CheckedChanged);
            // 
            // gerFlag_TBox
            // 
            this.gerFlag_TBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.gerFlag_TBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gerFlag_TBox.BackgroundImage")));
            this.gerFlag_TBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gerFlag_TBox.FlatAppearance.BorderSize = 4;
            this.gerFlag_TBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.gerFlag_TBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.gerFlag_TBox.Location = new System.Drawing.Point(588, 88);
            this.gerFlag_TBox.Name = "gerFlag_TBox";
            this.gerFlag_TBox.Size = new System.Drawing.Size(65, 44);
            this.gerFlag_TBox.TabIndex = 10;
            this.gerFlag_TBox.UseVisualStyleBackColor = true;
            this.gerFlag_TBox.CheckedChanged += new System.EventHandler(this.gerFlag_TBox_CheckedChanged);
            // 
            // hunLang_TBox
            // 
            this.hunLang_TBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.hunLang_TBox.BackgroundImage = global::IRF_Project_Work.Properties.Resources.hunFlag;
            this.hunLang_TBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hunLang_TBox.FlatAppearance.BorderSize = 4;
            this.hunLang_TBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.hunLang_TBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.hunLang_TBox.Location = new System.Drawing.Point(517, 88);
            this.hunLang_TBox.Name = "hunLang_TBox";
            this.hunLang_TBox.Size = new System.Drawing.Size(65, 44);
            this.hunLang_TBox.TabIndex = 9;
            this.hunLang_TBox.UseVisualStyleBackColor = true;
            this.hunLang_TBox.CheckedChanged += new System.EventHandler(this.hunLang_TBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.engFlag_TBox);
            this.Controls.Add(this.gerFlag_TBox);
            this.Controls.Add(this.hunLang_TBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.btn_GO);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Coord);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.radioBtn_Name);
            this.Controls.Add(this.radioBtn_Coord);
            this.Controls.Add(this.radioBtn_ID);
            this.Controls.Add(this.MainLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.RadioButton radioBtn_ID;
        private System.Windows.Forms.RadioButton radioBtn_Coord;
        private System.Windows.Forms.RadioButton radioBtn_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Coord;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btn_GO;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.CheckBox hunLang_TBox;
        private System.Windows.Forms.CheckBox gerFlag_TBox;
        private System.Windows.Forms.CheckBox engFlag_TBox;
    }
}

