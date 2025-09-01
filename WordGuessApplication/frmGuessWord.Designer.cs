namespace WordGuessApplication
{
    partial class frmGuessWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheck = new Button();
            txtGuess = new TextBox();
            lblWord = new Label();
            lstWrongGuesses = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.DarkSeaGreen;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(232, 245);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 42);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Guess";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(217, 187);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 42);
            txtGuess.TabIndex = 1;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.BackColor = Color.DarkSeaGreen;
            lblWord.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWord.ForeColor = Color.White;
            lblWord.Location = new Point(203, 122);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(164, 38);
            lblWord.TabIndex = 2;
            lblWord.Text = "R_V_R_E";
            // 
            // lstWrongGuesses
            // 
            lstWrongGuesses.FormattingEnabled = true;
            lstWrongGuesses.Location = new Point(497, 173);
            lstWrongGuesses.Name = "lstWrongGuesses";
            lstWrongGuesses.Size = new Size(172, 164);
            lstWrongGuesses.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(497, 130);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 4;
            label1.Text = "Wrong Guesses";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 61);
            label2.Name = "label2";
            label2.Size = new Size(175, 42);
            label2.TabIndex = 5;
            label2.Text = "R_V_R_E";
            // 
            // frmGuessWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstWrongGuesses);
            Controls.Add(lblWord);
            Controls.Add(txtGuess);
            Controls.Add(btnCheck);
            Name = "frmGuessWord";
            Text = "GUESSING GAME";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private TextBox txtGuess;
        private Label lblWord;
        private ListBox lstWrongGuesses;
        private Label label1;
        private Label label2;
    }
}
