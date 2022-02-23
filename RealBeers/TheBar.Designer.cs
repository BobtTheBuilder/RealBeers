namespace RealBeers
{
    partial class TheBar
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
            this.beer1 = new System.Windows.Forms.Button();
            this.beer2 = new System.Windows.Forms.Button();
            this.beer3 = new System.Windows.Forms.Button();
            this.beer4 = new System.Windows.Forms.Button();
            this.beer5 = new System.Windows.Forms.Button();
            this.beer6 = new System.Windows.Forms.Button();
            this.nodrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beer1
            // 
            this.beer1.Location = new System.Drawing.Point(92, 179);
            this.beer1.Name = "beer1";
            this.beer1.Size = new System.Drawing.Size(75, 23);
            this.beer1.TabIndex = 0;
            this.beer1.Text = "Beer 1";
            this.beer1.UseVisualStyleBackColor = true;
            this.beer1.Click += new System.EventHandler(this.beer1_Click);
            // 
            // beer2
            // 
            this.beer2.Location = new System.Drawing.Point(206, 148);
            this.beer2.Name = "beer2";
            this.beer2.Size = new System.Drawing.Size(75, 23);
            this.beer2.TabIndex = 1;
            this.beer2.Text = "Beer 2";
            this.beer2.UseVisualStyleBackColor = true;
            this.beer2.Click += new System.EventHandler(this.beer2_Click);
            // 
            // beer3
            // 
            this.beer3.Location = new System.Drawing.Point(328, 205);
            this.beer3.Name = "beer3";
            this.beer3.Size = new System.Drawing.Size(75, 23);
            this.beer3.TabIndex = 2;
            this.beer3.Text = "Beer 3";
            this.beer3.UseVisualStyleBackColor = true;
            this.beer3.Click += new System.EventHandler(this.beer3_Click);
            // 
            // beer4
            // 
            this.beer4.Location = new System.Drawing.Point(562, 205);
            this.beer4.Name = "beer4";
            this.beer4.Size = new System.Drawing.Size(75, 23);
            this.beer4.TabIndex = 3;
            this.beer4.Text = "Beer 4";
            this.beer4.UseVisualStyleBackColor = true;
            this.beer4.Click += new System.EventHandler(this.beer4_Click);
            // 
            // beer5
            // 
            this.beer5.Location = new System.Drawing.Point(436, 100);
            this.beer5.Name = "beer5";
            this.beer5.Size = new System.Drawing.Size(66, 22);
            this.beer5.TabIndex = 4;
            this.beer5.Text = "Beer 5";
            this.beer5.UseVisualStyleBackColor = true;
            this.beer5.Click += new System.EventHandler(this.beer5_Click);
            // 
            // beer6
            // 
            this.beer6.Location = new System.Drawing.Point(635, 99);
            this.beer6.Name = "beer6";
            this.beer6.Size = new System.Drawing.Size(70, 22);
            this.beer6.TabIndex = 5;
            this.beer6.Text = "Beer 6";
            this.beer6.UseVisualStyleBackColor = true;
            this.beer6.Click += new System.EventHandler(this.beer6_Click);
            // 
            // nodrink
            // 
            this.nodrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nodrink.Location = new System.Drawing.Point(598, 355);
            this.nodrink.Name = "nodrink";
            this.nodrink.Size = new System.Drawing.Size(157, 69);
            this.nodrink.TabIndex = 6;
            this.nodrink.Text = "DONT DRINK ?!!?!?!?";
            this.nodrink.UseVisualStyleBackColor = true;
            this.nodrink.Click += new System.EventHandler(this.nodrink_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "You and your friends go to a bar and get 6 special beers, you decide to drink fro" +
    "m each of the beers one by one.";
            // 
            // TheBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RealBeers.Properties.Resources.abeersrr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodrink);
            this.Controls.Add(this.beer6);
            this.Controls.Add(this.beer5);
            this.Controls.Add(this.beer4);
            this.Controls.Add(this.beer3);
            this.Controls.Add(this.beer2);
            this.Controls.Add(this.beer1);
            this.Name = "TheBar";
            this.Text = "In the Bar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beer1;
        private System.Windows.Forms.Button beer2;
        private System.Windows.Forms.Button beer3;
        private System.Windows.Forms.Button beer4;
        private System.Windows.Forms.Button beer5;
        private System.Windows.Forms.Button beer6;
        private System.Windows.Forms.Button nodrink;
        private System.Windows.Forms.Label label1;
    }
}

