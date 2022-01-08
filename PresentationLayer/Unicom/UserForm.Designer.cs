
namespace Unicom
{
    partial class UserForm
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonUserInsert = new System.Windows.Forms.Button();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.label_insertConfirm = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserFirstName = new System.Windows.Forms.Label();
            this.labelUserLastName = new System.Windows.Forms.Label();
            this.buttonMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(761, 199);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged_1);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(191, 238);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(139, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(362, 238);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(139, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(554, 238);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(139, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(21, 238);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(139, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // buttonUserInsert
            // 
            this.buttonUserInsert.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserInsert.Image = global::Unicom.Properties.Resources.application_put;
            this.buttonUserInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserInsert.Location = new System.Drawing.Point(140, 317);
            this.buttonUserInsert.Name = "buttonUserInsert";
            this.buttonUserInsert.Size = new System.Drawing.Size(90, 40);
            this.buttonUserInsert.TabIndex = 5;
            this.buttonUserInsert.Text = "INSERT";
            this.buttonUserInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserInsert.UseVisualStyleBackColor = true;
            this.buttonUserInsert.Click += new System.EventHandler(this.buttonUserInsert_Click);
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserUpdate.Image = global::Unicom.Properties.Resources.Update;
            this.buttonUserUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserUpdate.Location = new System.Drawing.Point(313, 317);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(89, 40);
            this.buttonUserUpdate.TabIndex = 6;
            this.buttonUserUpdate.Text = "UPDATE";
            this.buttonUserUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserUpdate.UseVisualStyleBackColor = true;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.BackgroundImage = global::Unicom.Properties.Resources.cappucino4;
            this.buttonUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserDelete.Image = global::Unicom.Properties.Resources.delete;
            this.buttonUserDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserDelete.Location = new System.Drawing.Point(491, 320);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(91, 37);
            this.buttonUserDelete.TabIndex = 7;
            this.buttonUserDelete.Text = "DELETE";
            this.buttonUserDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // label_insertConfirm
            // 
            this.label_insertConfirm.AutoSize = true;
            this.label_insertConfirm.Location = new System.Drawing.Point(137, 367);
            this.label_insertConfirm.Name = "label_insertConfirm";
            this.label_insertConfirm.Size = new System.Drawing.Size(0, 13);
            this.label_insertConfirm.TabIndex = 8;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.White;
            this.labelUserId.Location = new System.Drawing.Point(18, 222);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(44, 13);
            this.labelUserId.TabIndex = 9;
            this.labelUserId.Text = "User Id:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(188, 222);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username:";
            // 
            // labelUserFirstName
            // 
            this.labelUserFirstName.AutoSize = true;
            this.labelUserFirstName.BackColor = System.Drawing.Color.White;
            this.labelUserFirstName.Location = new System.Drawing.Point(359, 222);
            this.labelUserFirstName.Name = "labelUserFirstName";
            this.labelUserFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelUserFirstName.TabIndex = 11;
            this.labelUserFirstName.Text = "First name:";
            // 
            // labelUserLastName
            // 
            this.labelUserLastName.AutoSize = true;
            this.labelUserLastName.BackColor = System.Drawing.Color.White;
            this.labelUserLastName.Location = new System.Drawing.Point(551, 222);
            this.labelUserLastName.Name = "labelUserLastName";
            this.labelUserLastName.Size = new System.Drawing.Size(59, 13);
            this.labelUserLastName.TabIndex = 12;
            this.labelUserLastName.Text = "Last name:";
            // 
            // buttonMainForm
            // 
            this.buttonMainForm.BackgroundImage = global::Unicom.Properties.Resources.black;
            this.buttonMainForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMainForm.Image = global::Unicom.Properties.Resources.back;
            this.buttonMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainForm.Location = new System.Drawing.Point(12, 405);
            this.buttonMainForm.Name = "buttonMainForm";
            this.buttonMainForm.Size = new System.Drawing.Size(79, 33);
            this.buttonMainForm.TabIndex = 14;
            this.buttonMainForm.Text = "BACK";
            this.buttonMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMainForm.UseVisualStyleBackColor = true;
            this.buttonMainForm.Click += new System.EventHandler(this.buttonMainForm_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unicom.Properties.Resources.main3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMainForm);
            this.Controls.Add(this.labelUserLastName);
            this.Controls.Add(this.labelUserFirstName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.label_insertConfirm);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.buttonUserUpdate);
            this.Controls.Add(this.buttonUserInsert);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonUserInsert;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Label label_insertConfirm;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserFirstName;
        private System.Windows.Forms.Label labelUserLastName;
        private System.Windows.Forms.Button buttonMainForm;
    }
}