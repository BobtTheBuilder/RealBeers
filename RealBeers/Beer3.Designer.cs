﻿namespace RealBeers
{
    partial class Beer3
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
            this.talkmaf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // talkmaf
            // 
            this.talkmaf.BackColor = System.Drawing.Color.Silver;
            this.talkmaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.talkmaf.Location = new System.Drawing.Point(206, 9);
            this.talkmaf.Name = "talkmaf";
            this.talkmaf.Size = new System.Drawing.Size(342, 31);
            this.talkmaf.TabIndex = 0;
            this.talkmaf.Text = "You got drunk and sat down to talk with a bulgarian drunkard about \"kolko e proba" +
    "dnala taz durjava\"";
            this.talkmaf.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(177, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "He liked you, so he kidnapped you and brought you to a group of mafioso which dec" +
    "ided to let you join the Mafia.. ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(668, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back to the Bar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RealBeers.Properties.Resources.rusmaf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.talkmaf);
            this.Name = "Beer3";
            this.Text = "Bulgarian Mafia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label talkmaf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}