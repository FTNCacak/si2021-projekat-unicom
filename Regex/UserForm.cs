using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomBusiness;
using UnicomData;

namespace Unicom
{
    public partial class UserForm : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;
        public UserForm()
        {
            InitializeComponent();
            IKorisnikRepository korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness(korisnikRepository);

        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            GetAllKorisnik();
        }
        
        private void GetAllKorisnik()
        {
            listBoxUsers.Items.Clear();

            List<Korisnik> listOfItems = this.korisnikBusiness.GetAllKorisnik();

            foreach (Korisnik item in listOfItems)
            {
                listBoxUsers.Items.Add(item.Id + ". " + item.Username + ":\t" + item.First_Name + "\t-\t" + item.Last_Name + " Role: " + item.Role + " Gender: " + item.Gender);
            }
        }

        private void buttonUserInsert_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text =="" || comboBoxUserGender.Text == "" || comboBoxUserRole.Text == "" || textBoxUsername.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                if (!Regex.Match(textBoxFirstName.Text, "^[A-Z][a-z]*$").Success)
                {
                    MessageBox.Show("First name input has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxFirstName.Focus();
                    return;
                }
                if (!Regex.Match(textBoxLastName.Text, "^[A-Z][a-z]*$").Success)
                {
                    MessageBox.Show("Last name input has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxFirstName.Focus();
                    return;
                }
                if (!Regex.Match(textBoxUsername.Text, "^[a-z][a-z,0-9]*$").Success)
                {
                    MessageBox.Show("Username must contain small latters and numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxFirstName.Focus();
                    return;
                }
                Korisnik korisnik = new Korisnik();

                korisnik.Username = textBoxUsername.Text;
                korisnik.First_Name = textBoxFirstName.Text;
                korisnik.Last_Name = textBoxLastName.Text;
                korisnik.Role = comboBoxUserRole.Text;
                korisnik.Gender = comboBoxUserGender.Text;

                label_insertConfirm.Text = this.korisnikBusiness.InsertKorisnik(korisnik);

                textBoxUsername.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                comboBoxUserRole.Text = "";
                comboBoxUserGender.Text = "";

                GetAllKorisnik();


        }

        private void listBoxUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                Korisnik korisnik = new Korisnik();
                string selectedRow = listBoxUsers.SelectedItem.ToString();

                textBoxId.Text = selectedRow.Substring(0, selectedRow.IndexOf(". "));
                textBoxUsername.Text = selectedRow.Substring(selectedRow.IndexOf(".") + 2, selectedRow.IndexOf(":\t") - selectedRow.IndexOf(". ") - 2);
                textBoxFirstName.Text = selectedRow.Substring(selectedRow.IndexOf(":\t") + 2, selectedRow.IndexOf("\t-\t") - selectedRow.IndexOf(":\t") - 1);
                textBoxLastName.Text = selectedRow.Substring(selectedRow.IndexOf("\t-\t") + 3, selectedRow.IndexOf("Role:") - selectedRow.IndexOf("\t-\t")-4);
                comboBoxUserRole.Text = selectedRow.Substring(selectedRow.IndexOf("Role:")+ 6, selectedRow.IndexOf("Gender:") - selectedRow.IndexOf("Role:")-6);
                comboBoxUserGender.Text = selectedRow.Substring(selectedRow.IndexOf("Gender:") + 8);
            }

        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {

                Korisnik korisnik = new Korisnik();
                string selectedRow = listBoxUsers.SelectedItem.ToString();
                korisnik.Id = int.Parse(textBoxId.Text);
                korisnik.Username = textBoxUsername.Text;
                korisnik.First_Name = textBoxFirstName.Text;
                korisnik.Last_Name = textBoxLastName.Text;
                korisnik.Role = comboBoxUserRole.Text;
                korisnik.Gender = comboBoxUserGender.Text;

            string result = this.korisnikBusiness.UpdateKorisnik(korisnik);

                GetAllKorisnik();

                label_insertConfirm.Text = result;
            
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            // Takođe, kao kod ažuriranja, pročitamo Id iz tekstualnog polja (ostali podaci nam nisu potrebni),
            // važi isto kao za ažuriranje, potrebno je izvršiti validaciju tekstualnog polja za Id,
            // odnosno taster za brisanje treba da bude otključan samo ako je u tekstualnom polju prisutna celobrojna vrednost.
            int Id = int.Parse(textBoxId.Text);

            string result = this.korisnikBusiness.DeleteKorisnik(Id);

            GetAllKorisnik();

            label_insertConfirm.Text = result;
        }


        private void buttonMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm cf = new MainForm();
            cf.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
