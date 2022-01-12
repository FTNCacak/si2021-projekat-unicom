using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class RequestForm : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;
        private readonly IZahtevBusiness zahtevBusiness;

        public RequestForm()
        {
            InitializeComponent();
            IZahtevRepository zahtevRepository = new ZahtevRepository();
            this.zahtevBusiness = new ZahtevBusiness(zahtevRepository);
            IKorisnikRepository korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness(korisnikRepository);
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            GetAllZahtev();
        }
        private void GetAllZahtev()
        {
            listBoxRequests.Items.Clear();

            List<Zahtev> listOfItems = this.zahtevBusiness.GetAllZahtev();

            foreach (Zahtev item in listOfItems)
            {
                listBoxRequests.Items.Add(item.Id + ". " + item.Title + ":\t" + item.Description + "\t-\tUserId: " + item.UserId);
            }
        }

        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm cf = new MainForm();
            cf.Visible = true;
        }

        private void buttonRequestInsert_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || textBoxDescription.Text == "" || textBoxUserId.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(textBoxTitle.Text, "^[a-zA-Z0-9 ]*$").Success)
            {
                MessageBox.Show("Title input has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitle.Focus();
                return;
            }
            if (!Regex.Match(textBoxDescription.Text, @"^[a-zA-Z0-9 ]*$").Success)
            {
                MessageBox.Show("Description has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDescription.Focus();
                return;
            }
         // Za UserId nije potrebno jer je unos vec obezbedjen uslovom ispod.
         //   if (!Regex.Match(textBoxUserId.Text, "^[0-9][0-9]*$").Success)
         //   {
         //       MessageBox.Show("UserId must contain only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //       textBoxUserId.Focus();
         //       return;
         //   }

            List<Korisnik> KorisnikIdLista = new List<Korisnik>();
            int pom=0;

            KorisnikIdLista = this.korisnikBusiness.GetAllKorisnik();
            foreach (Korisnik item in KorisnikIdLista)
            {
                if (item.Id == Convert.ToInt32(textBoxUserId.Text))
                { 
                    Zahtev zahtev = new Zahtev();
                    zahtev.Title = textBoxTitle.Text;
                    zahtev.Description = textBoxDescription.Text;
                    zahtev.UserId = Convert.ToInt32(textBoxUserId.Text);
                    zahtev.Checked = false;
                    zahtev.Allowed = false;
                    pom++;
                    label_insertConfirm.Text = this.zahtevBusiness.InsertZahtev(zahtev);
                }   
            }
            if (pom == 0)
                MessageBox.Show("UserId doesn't exist in our database!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            textBoxTitle.Clear();
            textBoxDescription.Clear();
            textBoxUserId.Clear();

            GetAllZahtev();
        }

        private void listBoxRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRequests.SelectedItem != null)
            {
                Zahtev zahtev = new Zahtev();
                string selectedRow = listBoxRequests.SelectedItem.ToString();
                textBoxId.Text = selectedRow.Substring(0, selectedRow.IndexOf(". "));
                textBoxTitle.Text = selectedRow.Substring(selectedRow.IndexOf(".") + 2, selectedRow.IndexOf(":\t") - selectedRow.IndexOf(". ") - 2);
                textBoxDescription.Text = selectedRow.Substring(selectedRow.IndexOf(":\t") + 2, selectedRow.IndexOf("\t-\t") - selectedRow.IndexOf(":\t") - 1);
                textBoxUserId.Text = selectedRow.Substring(selectedRow.IndexOf("\t-\t") + 11);
            }
        }



        private void buttonRequestUpdate_Click(object sender, EventArgs e)
        {
            Zahtev zahtev = new Zahtev();
            string selectedRow = listBoxRequests.SelectedItem.ToString();
            zahtev.Id = int.Parse(textBoxId.Text);
            zahtev.Title = textBoxTitle.Text;
            zahtev.Description = textBoxDescription.Text;
            zahtev.UserId = Convert.ToInt32(textBoxUserId.Text);

            string result = this.zahtevBusiness.UpdateZahtev(zahtev);

            GetAllZahtev();

            label_insertConfirm.Text = result;

        }

        private void buttonRequestDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textBoxId.Text);

            string result = this.zahtevBusiness.DeleteZahtev(Id);

            GetAllZahtev();

            label_insertConfirm.Text = result;
        }
    }
}
