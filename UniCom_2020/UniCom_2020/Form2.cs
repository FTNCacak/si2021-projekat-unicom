using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCom_2020
{
    public partial class UniCom : Form
    {
        readonly UserBusiness userBusiness = new UserBusiness();
        public UniCom()
        {
            InitializeComponent();
        }

        private void UniCom_Load(object sender, EventArgs e)
        {

        }

        private void RefreshList()
        {
            listBoxUsers.Items.Clear();
            foreach (User user in userBusiness.GetUsers())
            {
                string userData = string.Format("{0}. {1}", user.UserID, user.First_Name);
                listBoxUsers.Items.Add(userData);
            }
        }

   
       

        private void buttonInsertUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                First_Name = textBoxFirstName.Text,
                Last_Name = textBoxLastName.Text,
            };

            userBusiness.InsertUser(user);

            RefreshList();

            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
        }
    }
}
