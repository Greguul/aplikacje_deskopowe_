namespace Egzamin_2021_06
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
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.emailBOX = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.passwordBOX = new System.Windows.Forms.TextBox();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.repeatpasswordBOX = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.BackColor = System.Drawing.Color.Teal;
            this.labelTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTittle.Location = new System.Drawing.Point(21, 25);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(196, 31);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "Rejestruj konto";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(19, 76);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(107, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Podaj e-mail:";
            // 
            // emailBOX
            // 
            this.emailBOX.Location = new System.Drawing.Point(23, 100);
            this.emailBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailBOX.Name = "emailBOX";
            this.emailBOX.Size = new System.Drawing.Size(200, 22);
            this.emailBOX.TabIndex = 2;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPass.Location = new System.Drawing.Point(19, 143);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(101, 20);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Podaj haslo:";
            // 
            // passwordBOX
            // 
            this.passwordBOX.Location = new System.Drawing.Point(23, 166);
            this.passwordBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBOX.Name = "passwordBOX";
            this.passwordBOX.Size = new System.Drawing.Size(200, 22);
            this.passwordBOX.TabIndex = 4;
            this.passwordBOX.UseSystemPasswordChar = true;
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPass2.Location = new System.Drawing.Point(24, 210);
            this.labelPass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(120, 20);
            this.labelPass2.TabIndex = 5;
            this.labelPass2.Text = "Powtorz haslo:";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAccept.Location = new System.Drawing.Point(105, 337);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(151, 70);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "ZATWIERDŹ";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // repeatpasswordBOX
            // 
            this.repeatpasswordBOX.Location = new System.Drawing.Point(28, 234);
            this.repeatpasswordBOX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repeatpasswordBOX.Name = "repeatpasswordBOX";
            this.repeatpasswordBOX.Size = new System.Drawing.Size(195, 22);
            this.repeatpasswordBOX.TabIndex = 8;
            this.repeatpasswordBOX.UseSystemPasswordChar = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(128, 423);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(389, 753);
            this.Controls.Add(this.label);
            this.Controls.Add(this.repeatpasswordBOX);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.passwordBOX);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.emailBOX);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTittle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox emailBOX;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox passwordBOX;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox repeatpasswordBOX;
        private System.Windows.Forms.Label label;
    }
}

