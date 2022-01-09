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
            MainForm cf = new MainForm();
            cf.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
