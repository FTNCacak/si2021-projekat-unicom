
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
            this.SuspendLayout();
            // 
            // buttonUserForm
            // 
            this.buttonUserForm.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserForm.Image = global::Unicom.Properties.Resources._001;
            this.buttonUserForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserForm.Location = new System.Drawing.Point(214, 183);
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
            this.buttonRequestForm.Location = new System.Drawing.Point(434, 183);
            this.buttonRequestForm.Name = "buttonRequestForm";
            this.buttonRequestForm.Size = new System.Drawing.Size(112, 33);
            this.buttonRequestForm.TabIndex = 1;
            this.buttonRequestForm.Text = "Request Form";
            this.buttonRequestForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestForm.UseVisualStyleBackColor = true;
            this.buttonRequestForm.Click += new System.EventHandler(this.buttonRequestForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom.Properties.Resources.main3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRequestForm);
            this.Controls.Add(this.buttonUserForm);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserForm;
        private System.Windows.Forms.Button buttonRequestForm;
    }
}

