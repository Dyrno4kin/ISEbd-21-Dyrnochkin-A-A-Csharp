﻿using System.Windows.Forms;

namespace WindowsFormsAirs
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeAir = new System.Windows.Forms.PictureBox();
            this.labelTakeAir = new System.Windows.Forms.Label();
            this.labelNumberMesto = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.TextBox();
            this.buttonTakeAir = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetAir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxHangar.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(403, 403);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // pictureBoxTakeAir
            // 
            this.pictureBoxTakeAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTakeAir.Location = new System.Drawing.Point(423, 241);
            this.pictureBoxTakeAir.Name = "pictureBoxTakeAir";
            this.pictureBoxTakeAir.Size = new System.Drawing.Size(179, 140);
            this.pictureBoxTakeAir.TabIndex = 1;
            this.pictureBoxTakeAir.TabStop = false;
            // 
            // labelTakeAir
            // 
            this.labelTakeAir.AutoSize = true;
            this.labelTakeAir.Location = new System.Drawing.Point(461, 199);
            this.labelTakeAir.Name = "labelTakeAir";
            this.labelTakeAir.Size = new System.Drawing.Size(122, 17);
            this.labelTakeAir.TabIndex = 4;
            this.labelTakeAir.Text = "Забрать самолет";
            // 
            // labelNumberMesto
            // 
            this.labelNumberMesto.AutoSize = true;
            this.labelNumberMesto.Location = new System.Drawing.Point(447, 218);
            this.labelNumberMesto.Name = "labelNumberMesto";
            this.labelNumberMesto.Size = new System.Drawing.Size(53, 17);
            this.labelNumberMesto.TabIndex = 5;
            this.labelNumberMesto.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(513, 215);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(73, 22);
            this.maskedTextBox.TabIndex = 6;
            // 
            // buttonTakeAir
            // 
            this.buttonTakeAir.Location = new System.Drawing.Point(423, 387);
            this.buttonTakeAir.Name = "buttonTakeAir";
            this.buttonTakeAir.Size = new System.Drawing.Size(179, 28);
            this.buttonTakeAir.TabIndex = 7;
            this.buttonTakeAir.Text = "Забрать";
            this.buttonTakeAir.UseVisualStyleBackColor = true;
            this.buttonTakeAir.Click += new System.EventHandler(this.buttonTakeAir_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(426, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(176, 116);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonSetAir
            // 
            this.buttonSetAir.Location = new System.Drawing.Point(428, 152);
            this.buttonSetAir.Name = "buttonSetAir";
            this.buttonSetAir.Size = new System.Drawing.Size(173, 47);
            this.buttonSetAir.TabIndex = 9;
            this.buttonSetAir.Text = "Добавить самолет";
            this.buttonSetAir.UseVisualStyleBackColor = true;
            this.buttonSetAir.Click += new System.EventHandler(this.ButtonSetAir_Click);
            // 
            // FormHangar
            // 
            this.ClientSize = new System.Drawing.Size(611, 424);
            this.Controls.Add(this.buttonSetAir);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonTakeAir);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelNumberMesto);
            this.Controls.Add(this.labelTakeAir);
            this.Controls.Add(this.pictureBoxTakeAir);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxHangar;
        private PictureBox pictureBoxTakeAir;
        private Label labelTakeAir;
        private Label labelNumberMesto;
        private TextBox maskedTextBox;
        private Button buttonTakeAir;
        private ListBox listBoxLevels;
        private Button buttonSetAir;
    }
}