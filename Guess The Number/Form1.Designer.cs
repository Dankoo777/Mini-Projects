namespace Guess_The_Number
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.buttonTry = new System.Windows.Forms.Button();
            this.textBoxans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtries = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonStart.Location = new System.Drawing.Point(13, 19);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(210, 67);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начало";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Въведи число: ";
            // 
            // textBoxnum
            // 
            this.textBoxnum.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxnum.Location = new System.Drawing.Point(147, 117);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(76, 26);
            this.textBoxnum.TabIndex = 2;
            this.textBoxnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTry
            // 
            this.buttonTry.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTry.Location = new System.Drawing.Point(13, 176);
            this.buttonTry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(210, 67);
            this.buttonTry.TabIndex = 3;
            this.buttonTry.Text = "Опит";
            this.buttonTry.UseVisualStyleBackColor = false;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // textBoxans
            // 
            this.textBoxans.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxans.Location = new System.Drawing.Point(140, 275);
            this.textBoxans.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxans.Name = "textBoxans";
            this.textBoxans.ReadOnly = true;
            this.textBoxans.Size = new System.Drawing.Size(83, 26);
            this.textBoxans.TabIndex = 5;
            this.textBoxans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(13, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отговор:";
            // 
            // textBoxtries
            // 
            this.textBoxtries.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxtries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtries.Location = new System.Drawing.Point(140, 332);
            this.textBoxtries.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtries.Name = "textBoxtries";
            this.textBoxtries.ReadOnly = true;
            this.textBoxtries.Size = new System.Drawing.Size(83, 26);
            this.textBoxtries.TabIndex = 7;
            this.textBoxtries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(13, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Брой опити:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(236, 380);
            this.Controls.Add(this.textBoxtries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTry);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Познай числото";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Button buttonTry;
        private System.Windows.Forms.TextBox textBoxans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxtries;
        private System.Windows.Forms.Label label3;
    }
}

