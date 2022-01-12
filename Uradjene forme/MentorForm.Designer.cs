
namespace Unicom
{
    partial class MentorForm
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
            this.listBoxRequestFilter = new System.Windows.Forms.ListBox();
            this.buttonUserCheck = new System.Windows.Forms.Button();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.textBoxRequestFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRequestFilter
            // 
            this.listBoxRequestFilter.FormattingEnabled = true;
            this.listBoxRequestFilter.Location = new System.Drawing.Point(27, 12);
            this.listBoxRequestFilter.Name = "listBoxRequestFilter";
            this.listBoxRequestFilter.Size = new System.Drawing.Size(761, 199);
            this.listBoxRequestFilter.TabIndex = 1;
            this.listBoxRequestFilter.SelectedIndexChanged += new System.EventHandler(this.listBoxRequestFilter_SelectedIndexChanged);
            // 
            // buttonUserCheck
            // 
            this.buttonUserCheck.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserCheck.Image = global::Unicom.Properties.Resources.OK1;
            this.buttonUserCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserCheck.Location = new System.Drawing.Point(243, 276);
            this.buttonUserCheck.Name = "buttonUserCheck";
            this.buttonUserCheck.Size = new System.Drawing.Size(89, 40);
            this.buttonUserCheck.TabIndex = 2;
            this.buttonUserCheck.Text = "CHECK";
            this.buttonUserCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserCheck.UseVisualStyleBackColor = true;
            this.buttonUserCheck.Click += new System.EventHandler(this.buttonUserCheck_Click);
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(340, 287);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(151, 20);
            this.textBoxCheck.TabIndex = 3;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(303, 256);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(222, 13);
            this.labelCheck.TabIndex = 4;
            this.labelCheck.Text = "Please type in your Id to check your authority!";
            // 
            // textBoxRequestFilter
            // 
            this.textBoxRequestFilter.Enabled = false;
            this.textBoxRequestFilter.Location = new System.Drawing.Point(340, 366);
            this.textBoxRequestFilter.Name = "textBoxRequestFilter";
            this.textBoxRequestFilter.Size = new System.Drawing.Size(151, 20);
            this.textBoxRequestFilter.TabIndex = 5;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonFilter.Enabled = false;
            this.buttonFilter.Image = global::Unicom.Properties.Resources.filter;
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(243, 355);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(89, 40);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "FILTER";
            this.buttonFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(295, 330);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(231, 13);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "Plese enter the Id\'s of Requests you find viable:";
            this.labelFilter.Visible = false;
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
            // MentorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom.Properties.Resources.main3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxRequestFilter);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.textBoxCheck);
            this.Controls.Add(this.buttonUserCheck);
            this.Controls.Add(this.listBoxRequestFilter);
            this.Name = "MentorForm";
            this.Text = "Mentor";
            this.Load += new System.EventHandler(this.MentorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRequestFilter;
        private System.Windows.Forms.Button buttonUserCheck;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.TextBox textBoxRequestFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonBack;
    }
}