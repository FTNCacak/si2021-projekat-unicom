﻿using BusinessLayer;
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
    public partial class Form1 : Form
    {
        readonly UserBusiness userBusiness = new UserBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            listBoxUsers.Items.Clear();
            foreach (User user in userBusiness.GetUsers())
            {
                string itemData = string.Format("{0},{1},{2},{3},{4}", user.UserID, user.username, user.First_Name, user.Last_Name, user.Year_of_Birth);
                listBoxUsers.Items.Add(itemData);


            }
        }

        private void buttonInsertUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                username = textBoxUsername.Text,
                First_Name = textBoxFirstName.Text,
                Last_Name = textBoxLastName.Text,
                Year_of_Birth = Convert.ToInt32(textBoxYearofBirth.Text)
            };

            userBusiness.InsertUser(user);

            RefreshList();

            textBoxUsername.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxYearofBirth.Text = string.Empty;
        }
    }
}
