
namespace Unicom
{
    partial class AdministrationForm
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
            this.listBoxRequestAllow = new System.Windows.Forms.ListBox();
            this.labelAllow = new System.Windows.Forms.Label();
            this.buttonAllow = new System.Windows.Forms.Button();
            this.textBoxRequestAllow = new System.Windows.Forms.TextBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.buttonUserCheck = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRequestAllow
            // 
            this.listBoxRequestAllow.FormattingEnabled = true;
            this.listBoxRequestAllow.Location = new System.Drawing.Point(12, 12);
            this.listBoxRequestAllow.Name = "listBoxRequestAllow";
            this.listBoxRequestAllow.Size = new System.Drawing.Size(761, 199);
            this.listBoxRequestAllow.TabIndex = 2;
            this.listBoxRequestAllow.SelectedIndexChanged += new System.EventHandler(this.listBoxRequestAllow_SelectedIndexChanged);
            // 
            // labelAllow
            // 
            this.labelAllow.AutoSize = true;
            this.labelAllow.Location = new System.Drawing.Point(274, 336);
            this.labelAllow.Name = "labelAllow";
            this.labelAllow.Size = new System.Drawing.Size(231, 13);
            this.labelAllow.TabIndex = 13;
            this.labelAllow.Text = "Plese enter the Id\'s of Requests you find viable:";
            this.labelAllow.Visible = false;
            // 
            // buttonAllow
            // 
            this.buttonAllow.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonAllow.Enabled = false;
            this.buttonAllow.Image = global::Unicom.Properties.Resources.ok2;
            this.buttonAllow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllow.Location = new System.Drawing.Point(215, 360);
            this.buttonAllow.Name = "buttonAllow";
            this.buttonAllow.Size = new System.Drawing.Size(91, 43);
            this.buttonAllow.TabIndex = 12;
            this.buttonAllow.Text = "ALLOW";
            this.buttonAllow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAllow.UseVisualStyleBackColor = true;
            this.buttonAllow.Click += new System.EventHandler(this.buttonAllow_Click);
            // 
            // textBoxRequestAllow
            // 
            this.textBoxRequestAllow.Enabled = false;
            this.textBoxRequestAllow.Location = new System.Drawing.Point(328, 372);
            this.textBoxRequestAllow.Name = "textBoxRequestAllow";
            this.textBoxRequestAllow.Size = new System.Drawing.Size(137, 20);
            this.textBoxRequestAllow.TabIndex = 11;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(284, 261);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(222, 13);
            this.labelCheck.TabIndex = 10;
            this.labelCheck.Text = "Please type in your Id to check your authority!";
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(328, 296);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(137, 20);
            this.textBoxCheck.TabIndex = 9;
            // 
            // buttonUserCheck
            // 
            this.buttonUserCheck.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserCheck.Image = global::Unicom.Properties.Resources.OK;
            this.buttonUserCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserCheck.Location = new System.Drawing.Point(215, 283);
            this.buttonUserCheck.Name = "buttonUserCheck";
            this.buttonUserCheck.Size = new System.Drawing.Size(91, 42);
            this.buttonUserCheck.TabIndex = 8;
            this.buttonUserCheck.Text = "CHECK";
            this.buttonUserCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserCheck.UseVisualStyleBackColor = true;
            this.buttonUserCheck.Click += new System.EventHandler(this.buttonUserCheck_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::Unicom.Properties.Resources.black;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Image = global::Unicom.Properties.Resources.back;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(12, 404);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 34);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "BACK";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom.Properties.Resources.main3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAllow);
            this.Controls.Add(this.buttonAllow);
            this.Controls.Add(this.textBoxRequestAllow);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.textBoxCheck);
            this.Controls.Add(this.buttonUserCheck);
            this.Controls.Add(this.listBoxRequestAllow);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRequestAllow;
        private System.Windows.Forms.Label labelAllow;
        private System.Windows.Forms.Button buttonAllow;
        private System.Windows.Forms.TextBox textBoxRequestAllow;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.Button buttonUserCheck;
        private System.Windows.Forms.Button buttonBack;
    }
}