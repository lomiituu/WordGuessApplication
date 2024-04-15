namespace WordGuessApplication
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guessbutton = new System.Windows.Forms.Button();
            this.wrongGuesses = new System.Windows.Forms.Label();
            this.wrongGuessList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "c????s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessbutton
            // 
            this.guessbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.guessbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessbutton.ForeColor = System.Drawing.Color.White;
            this.guessbutton.Location = new System.Drawing.Point(205, 211);
            this.guessbutton.Name = "guessbutton";
            this.guessbutton.Size = new System.Drawing.Size(92, 30);
            this.guessbutton.TabIndex = 2;
            this.guessbutton.Text = "Guess";
            this.guessbutton.UseVisualStyleBackColor = false;
            this.guessbutton.Click += new System.EventHandler(this.guessbutton_Click);
            // 
            // wrongGuesses
            // 
            this.wrongGuesses.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wrongGuesses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongGuesses.ForeColor = System.Drawing.Color.White;
            this.wrongGuesses.Location = new System.Drawing.Point(458, 111);
            this.wrongGuesses.Name = "wrongGuesses";
            this.wrongGuesses.Size = new System.Drawing.Size(156, 28);
            this.wrongGuesses.TabIndex = 3;
            this.wrongGuesses.Text = "Wrong guesses";
            this.wrongGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongGuessList
            // 
            this.wrongGuessList.BackColor = System.Drawing.Color.White;
            this.wrongGuessList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongGuessList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wrongGuessList.Location = new System.Drawing.Point(449, 152);
            this.wrongGuessList.Name = "wrongGuessList";
            this.wrongGuessList.Size = new System.Drawing.Size(178, 167);
            this.wrongGuessList.TabIndex = 4;
            this.wrongGuessList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wrongGuessList);
            this.Controls.Add(this.wrongGuesses);
            this.Controls.Add(this.guessbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guessbutton;
        private System.Windows.Forms.Label wrongGuesses;
        private System.Windows.Forms.Label wrongGuessList;
    }
}

