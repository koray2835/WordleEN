namespace Wordle
{
    partial class Form1
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
            txtGuess = new TextBox();
            btnSubmit = new Button();
            lblAttempts = new Label();
            flpGuesses = new FlowLayoutPanel();
            label1 = new Label();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(12, 305);
            txtGuess.MaxLength = 5;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 0;
            txtGuess.KeyPress += txtGuess_KeyPress;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(129, 304);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Enter";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.ForeColor = Color.White;
            lblAttempts.Location = new Point(12, 282);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(200, 20);
            lblAttempts.TabIndex = 3;
            lblAttempts.Text = "Number of Guesses";
            lblAttempts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpGuesses
            // 
            flpGuesses.AutoScroll = true;
            flpGuesses.Location = new Point(12, 39);
            flpGuesses.Name = "flpGuesses";
            flpGuesses.Size = new Size(192, 240);
            flpGuesses.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 285);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(200, 23);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "WORDLE";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(207, 334);
            Controls.Add(lblHeader);
            Controls.Add(label1);
            Controls.Add(flpGuesses);
            Controls.Add(lblAttempts);
            Controls.Add(btnSubmit);
            Controls.Add(txtGuess);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuess;
        private Button btnSubmit;
        private Label lblAttempts;
        private FlowLayoutPanel flpGuesses;
        private Label label1;
        private Label lblHeader;
    }
}
