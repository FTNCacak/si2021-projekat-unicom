
namespace Unicom
{
    partial class MainForm
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
            this.buttonUserForm = new System.Windows.Forms.Button();
            this.buttonRequestForm = new System.Windows.Forms.Button();
            this.buttonMentorForm = new System.Windows.Forms.Button();
            this.buttonAdministratorForm = new System.Windows.Forms.Button();
            this.listBoxOdobreniZahtevi = new System.Windows.Forms.ListBox();
            this.labelOdobreniZahtevi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUserForm
            // 
            this.buttonUserForm.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserForm.Image = global::Unicom.Properties.Resources._001;
            this.buttonUserForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserForm.Location = new System.Drawing.Point(91, 79);
            this.buttonUserForm.Name = "buttonUserForm";
            this.buttonUserForm.Size = new System.Drawing.Size(104, 33);
            this.buttonUserForm.TabIndex = 0;
            this.buttonUserForm.Text = "User Form";
            this.buttonUserForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserForm.UseVisualStyleBackColor = true;
            this.buttonUserForm.Click += new System.EventHandler(this.buttonUserForm_Click);
            // 
            // buttonRequestForm
            // 
            this.buttonRequestForm.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonRequestForm.Image = global::Unicom.Properties.Resources.Messages32px;
            this.buttonRequestForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestForm.Location = new System.Drawing.Point(252, 79);
            this.buttonRequestForm.Name = "buttonRequestForm";
            this.buttonRequestForm.Size = new System.Drawing.Size(112, 33);
            this.buttonRequestForm.TabIndex = 1;
            this.buttonRequestForm.Text = "Request Form";
            this.buttonRequestForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestForm.UseVisualStyleBackColor = true;
            this.buttonRequestForm.Click += new System.EventHandler(this.buttonRequestForm_Click);
            // 
            // buttonMentorForm
            // 
            this.buttonMentorForm.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonMentorForm.Image = global::Unicom.Properties.Resources.Filter_List;
            this.buttonMentorForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMentorForm.Location = new System.Drawing.Point(417, 79);
            this.buttonMentorForm.Name = "buttonMentorForm";
            this.buttonMentorForm.Size = new System.Drawing.Size(105, 33);
            this.buttonMentorForm.TabIndex = 2;
            this.buttonMentorForm.Text = "Mentor Form";
            this.buttonMentorForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMentorForm.UseVisualStyleBackColor = true;
            this.buttonMentorForm.Click += new System.EventHandler(this.buttonMentorForm_Click);
            // 
            // buttonAdministratorForm
            // 
            this.buttonAdministratorForm.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonAdministratorForm.Image = global::Unicom.Properties.Resources.Administrative_Tools;
            this.buttonAdministratorForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdministratorForm.Location = new System.Drawing.Point(571, 79);
            this.buttonAdministratorForm.Name = "buttonAdministratorForm";
            this.buttonAdministratorForm.Size = new System.Drawing.Size(111, 33);
            this.buttonAdministratorForm.TabIndex = 3;
            this.buttonAdministratorForm.Text = "Administration";
            this.buttonAdministratorForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdministratorForm.UseVisualStyleBackColor = true;
            this.buttonAdministratorForm.Click += new System.EventHandler(this.buttonAdministratorForm_Click);
            // 
            // listBoxOdobreniZahtevi
            // 
            this.listBoxOdobreniZahtevi.FormattingEnabled = true;
            this.listBoxOdobreniZahtevi.Location = new System.Drawing.Point(91, 201);
            this.listBoxOdobreniZahtevi.Name = "listBoxOdobreniZahtevi";
            this.listBoxOdobreniZahtevi.Size = new System.Drawing.Size(591, 160);
            this.listBoxOdobreniZahtevi.TabIndex = 4;
            // 
            // labelOdobreniZahtevi
            // 
            this.labelOdobreniZahtevi.AutoSize = true;
            this.labelOdobreniZahtevi.Location = new System.Drawing.Point(88, 185);
            this.labelOdobreniZahtevi.Name = "labelOdobreniZahtevi";
            this.labelOdobreniZahtevi.Size = new System.Drawing.Size(236, 13);
            this.labelOdobreniZahtevi.TabIndex = 5;
            this.labelOdobreniZahtevi.Text = "Lista zahteva odobrenih od strane administracije:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom.Properties.Resources.main3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOdobreniZahtevi);
            this.Controls.Add(this.listBoxOdobreniZahtevi);
            this.Controls.Add(this.buttonAdministratorForm);
            this.Controls.Add(this.buttonMentorForm);
            this.Controls.Add(this.buttonRequestForm);
            this.Controls.Add(this.buttonUserForm);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserForm;
        private System.Windows.Forms.Button buttonRequestForm;
        private System.Windows.Forms.Button buttonMentorForm;
        private System.Windows.Forms.Button buttonAdministratorForm;
        private System.Windows.Forms.ListBox listBoxOdobreniZahtevi;
        private System.Windows.Forms.Label labelOdobreniZahtevi;
    }
}

