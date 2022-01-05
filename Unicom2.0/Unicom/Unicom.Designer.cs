
namespace Unicom
{
    partial class Unicom
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
            this.listBoxKorisniks = new System.Windows.Forms.ListBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxYearofBirth = new System.Windows.Forms.TextBox();
            this.buttonInsertKorisnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxKorisniks
            // 
            this.listBoxKorisniks.FormattingEnabled = true;
            this.listBoxKorisniks.Location = new System.Drawing.Point(155, 269);
            this.listBoxKorisniks.Name = "listBoxKorisniks";
            this.listBoxKorisniks.Size = new System.Drawing.Size(306, 95);
            this.listBoxKorisniks.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(189, 49);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(225, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(189, 94);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(225, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(189, 137);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(225, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxYearofBirth
            // 
            this.textBoxYearofBirth.Location = new System.Drawing.Point(189, 180);
            this.textBoxYearofBirth.Name = "textBoxYearofBirth";
            this.textBoxYearofBirth.Size = new System.Drawing.Size(225, 20);
            this.textBoxYearofBirth.TabIndex = 4;
            // 
            // buttonInsertKorisnik
            // 
            this.buttonInsertKorisnik.Location = new System.Drawing.Point(268, 216);
            this.buttonInsertKorisnik.Name = "buttonInsertKorisnik";
            this.buttonInsertKorisnik.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertKorisnik.TabIndex = 5;
            this.buttonInsertKorisnik.Text = "ADD";
            this.buttonInsertKorisnik.UseVisualStyleBackColor = true;
            this.buttonInsertKorisnik.Click += new System.EventHandler(this.buttonInsertKorisnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year of birth";
            // 
            // Unicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertKorisnik);
            this.Controls.Add(this.textBoxYearofBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.listBoxKorisniks);
            this.Name = "Unicom";
            this.Text = "Unicom";
            this.Load += new System.EventHandler(this.Unicom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKorisniks;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxYearofBirth;
        private System.Windows.Forms.Button buttonInsertKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

