﻿namespace Pokedex_2._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            this.imagePbox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debugTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.TypeTbox = new System.Windows.Forms.TextBox();
            this.levelTbox = new System.Windows.Forms.TextBox();
            this.shinyCbox = new System.Windows.Forms.CheckBox();
            this.legendaryCbox = new System.Windows.Forms.CheckBox();
            this.hpUpDown = new System.Windows.Forms.NumericUpDown();
            this.expUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.genUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pokedex_2._0.Properties.Resources.pokedex_3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(588, 174);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(44, 16);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(588, 193);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(39, 16);
            this.typeLbl.TabIndex = 2;
            this.typeLbl.Text = "Type";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Location = new System.Drawing.Point(588, 213);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(40, 16);
            this.levelLbl.TabIndex = 3;
            this.levelLbl.Text = "Level";
            // 
            // imagePbox
            // 
            this.imagePbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagePbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePbox.Location = new System.Drawing.Point(220, 174);
            this.imagePbox.Name = "imagePbox";
            this.imagePbox.Size = new System.Drawing.Size(232, 144);
            this.imagePbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePbox.TabIndex = 4;
            this.imagePbox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "EXP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "HP";
            // 
            // debugTbox
            // 
            this.debugTbox.Location = new System.Drawing.Point(890, 174);
            this.debugTbox.Multiline = true;
            this.debugTbox.Name = "debugTbox";
            this.debugTbox.Size = new System.Drawing.Size(94, 293);
            this.debugTbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gen";
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(633, 168);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(169, 22);
            this.nameTbox.TabIndex = 12;
            // 
            // TypeTbox
            // 
            this.TypeTbox.Location = new System.Drawing.Point(633, 190);
            this.TypeTbox.Name = "TypeTbox";
            this.TypeTbox.Size = new System.Drawing.Size(52, 22);
            this.TypeTbox.TabIndex = 13;
            // 
            // levelTbox
            // 
            this.levelTbox.Location = new System.Drawing.Point(633, 213);
            this.levelTbox.Name = "levelTbox";
            this.levelTbox.Size = new System.Drawing.Size(52, 22);
            this.levelTbox.TabIndex = 14;
            // 
            // shinyCbox
            // 
            this.shinyCbox.AutoSize = true;
            this.shinyCbox.Location = new System.Drawing.Point(692, 192);
            this.shinyCbox.Name = "shinyCbox";
            this.shinyCbox.Size = new System.Drawing.Size(62, 20);
            this.shinyCbox.TabIndex = 15;
            this.shinyCbox.Text = "Shiny";
            this.shinyCbox.UseVisualStyleBackColor = true;
            // 
            // legendaryCbox
            // 
            this.legendaryCbox.AutoSize = true;
            this.legendaryCbox.Location = new System.Drawing.Point(692, 212);
            this.legendaryCbox.Name = "legendaryCbox";
            this.legendaryCbox.Size = new System.Drawing.Size(94, 20);
            this.legendaryCbox.TabIndex = 16;
            this.legendaryCbox.Text = "Legendary";
            this.legendaryCbox.UseVisualStyleBackColor = true;
            // 
            // hpUpDown
            // 
            this.hpUpDown.Location = new System.Drawing.Point(614, 427);
            this.hpUpDown.Name = "hpUpDown";
            this.hpUpDown.Size = new System.Drawing.Size(59, 22);
            this.hpUpDown.TabIndex = 17;
            // 
            // expUpDown
            // 
            this.expUpDown.Location = new System.Drawing.Point(760, 427);
            this.expUpDown.Name = "expUpDown";
            this.expUpDown.Size = new System.Drawing.Size(52, 22);
            this.expUpDown.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SaveBtn.Location = new System.Drawing.Point(247, 427);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 51);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // genUpDown
            // 
            this.genUpDown.Location = new System.Drawing.Point(626, 360);
            this.genUpDown.Name = "genUpDown";
            this.genUpDown.Size = new System.Drawing.Size(47, 22);
            this.genUpDown.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 542);
            this.Controls.Add(this.genUpDown);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.expUpDown);
            this.Controls.Add(this.hpUpDown);
            this.Controls.Add(this.legendaryCbox);
            this.Controls.Add(this.shinyCbox);
            this.Controls.Add(this.levelTbox);
            this.Controls.Add(this.TypeTbox);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imagePbox);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Pokedex 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.PictureBox imagePbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox debugTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.TextBox TypeTbox;
        private System.Windows.Forms.TextBox levelTbox;
        private System.Windows.Forms.CheckBox shinyCbox;
        private System.Windows.Forms.CheckBox legendaryCbox;
        private System.Windows.Forms.NumericUpDown hpUpDown;
        private System.Windows.Forms.NumericUpDown expUpDown;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.NumericUpDown genUpDown;
    }
}
