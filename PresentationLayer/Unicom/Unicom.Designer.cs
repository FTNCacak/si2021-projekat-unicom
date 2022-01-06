
namespace Magacin
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
            this.listBoxKorisnik = new System.Windows.Forms.ListBox();
            this.label_KorisnikUsername = new System.Windows.Forms.Label();
            this.label_KorisnikFIrstName = new System.Windows.Forms.Label();
            this.label_KorisnikLastName = new System.Windows.Forms.Label();
            this.textBox_KorisnikUsername = new System.Windows.Forms.TextBox();
            this.textBox_KorisnikFirstName = new System.Windows.Forms.TextBox();
            this.textBox_KorisnikLastName = new System.Windows.Forms.TextBox();
            this.button_KorisnikInsert = new System.Windows.Forms.Button();
            this.label_insertConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxKorisnik
            // 
            this.listBoxKorisnik.FormattingEnabled = true;
            this.listBoxKorisnik.Location = new System.Drawing.Point(31, 21);
            this.listBoxKorisnik.Name = "listBoxKorisnik";
            this.listBoxKorisnik.Size = new System.Drawing.Size(515, 199);
            this.listBoxKorisnik.TabIndex = 0;
            this.listBoxKorisnik.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // label_KorisnikUsername
            // 
            this.label_KorisnikUsername.AutoSize = true;
            this.label_KorisnikUsername.Location = new System.Drawing.Point(25, 260);
            this.label_KorisnikUsername.Name = "label_KorisnikUsername";
            this.label_KorisnikUsername.Size = new System.Drawing.Size(61, 13);
            this.label_KorisnikUsername.TabIndex = 1;
            this.label_KorisnikUsername.Text = "Username:";
            // 
            // label_KorisnikFIrstName
            // 
            this.label_KorisnikFIrstName.AutoSize = true;
            this.label_KorisnikFIrstName.Location = new System.Drawing.Point(28, 297);
            this.label_KorisnikFIrstName.Name = "label_KorisnikFIrstName";
            this.label_KorisnikFIrstName.Size = new System.Drawing.Size(64, 13);
            this.label_KorisnikFIrstName.TabIndex = 2;
            this.label_KorisnikFIrstName.Text = "First Name:";
            // 
            // label_KorisnikLastName
            // 
            this.label_KorisnikLastName.AutoSize = true;
            this.label_KorisnikLastName.Location = new System.Drawing.Point(31, 338);
            this.label_KorisnikLastName.Name = "label_KorisnikLastName";
            this.label_KorisnikLastName.Size = new System.Drawing.Size(81, 13);
            this.label_KorisnikLastName.TabIndex = 3;
            this.label_KorisnikLastName.Text = "Item Discount:";
            // 
            // textBox_KorisnikUsername
            // 
            this.textBox_KorisnikUsername.Location = new System.Drawing.Point(121, 260);
            this.textBox_KorisnikUsername.Name = "textBox_KorisnikUsername";
            this.textBox_KorisnikUsername.Size = new System.Drawing.Size(184, 22);
            this.textBox_KorisnikUsername.TabIndex = 4;
            // 
            // textBox_KorisnikFirstName
            // 
            this.textBox_KorisnikFirstName.Location = new System.Drawing.Point(121, 297);
            this.textBox_KorisnikFirstName.Name = "textBox_KorisnikFirstName";
            this.textBox_KorisnikFirstName.Size = new System.Drawing.Size(184, 22);
            this.textBox_KorisnikFirstName.TabIndex = 5;
            // 
            // textBox_KorisnikLastName
            // 
            this.textBox_KorisnikLastName.Location = new System.Drawing.Point(121, 338);
            this.textBox_KorisnikLastName.Name = "textBox_KorisnikLastName";
            this.textBox_KorisnikLastName.Size = new System.Drawing.Size(184, 22);
            this.textBox_KorisnikLastName.TabIndex = 6;
            // 
            // button_KorisnikInsert
            // 
            this.button_KorisnikInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_KorisnikInsert.Location = new System.Drawing.Point(374, 289);
            this.button_KorisnikInsert.Name = "button_KorisnikInsert";
            this.button_KorisnikInsert.Size = new System.Drawing.Size(68, 34);
            this.button_KorisnikInsert.TabIndex = 7;
            this.button_KorisnikInsert.Text = "INSERT";
            this.button_KorisnikInsert.UseVisualStyleBackColor = false;
            this.button_KorisnikInsert.Click += new System.EventHandler(this.button_itemInsert_Click);
            // 
            // label_insertConfirm
            // 
            this.label_insertConfirm.AutoSize = true;
            this.label_insertConfirm.Location = new System.Drawing.Point(371, 377);
            this.label_insertConfirm.Name = "label_insertConfirm";
            this.label_insertConfirm.Size = new System.Drawing.Size(0, 13);
            this.label_insertConfirm.TabIndex = 8;
            // 
            // Unicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(569, 445);
            this.Controls.Add(this.label_insertConfirm);
            this.Controls.Add(this.button_KorisnikInsert);
            this.Controls.Add(this.textBox_KorisnikLastName);
            this.Controls.Add(this.textBox_KorisnikFirstName);
            this.Controls.Add(this.textBox_KorisnikUsername);
            this.Controls.Add(this.label_KorisnikLastName);
            this.Controls.Add(this.label_KorisnikFIrstName);
            this.Controls.Add(this.label_KorisnikUsername);
            this.Controls.Add(this.listBoxKorisnik);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Unicom";
            this.Text = "Unicom";
            this.Load += new System.EventHandler(this.Magacin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKorisnik;
        private System.Windows.Forms.Label label_KorisnikUsername;
        private System.Windows.Forms.Label label_KorisnikFIrstName;
        private System.Windows.Forms.Label label_KorisnikLastName;
        private System.Windows.Forms.TextBox textBox_KorisnikUsername;
        private System.Windows.Forms.TextBox textBox_KorisnikFirstName;
        private System.Windows.Forms.TextBox textBox_KorisnikLastName;
        private System.Windows.Forms.Button button_KorisnikInsert;
        private System.Windows.Forms.Label label_insertConfirm;
    }
}

