using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomBusiness;
using UnicomData;

namespace Unicom
{
    public partial class AdministrationForm : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;
        private readonly IZahtevBusiness zahtevBusiness;
        public AdministrationForm()
        {
            InitializeComponent();
            IZahtevRepository zahtevRepository = new ZahtevRepository();
            this.zahtevBusiness = new ZahtevBusiness(zahtevRepository);
            IKorisnikRepository korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness(korisnikRepository);
        }
        private void GetAllZahtev()
        {
            listBoxRequestAllow.Items.Clear();

            List<Zahtev> listOfItems = this.zahtevBusiness.GetAllZahtev();

            foreach (Zahtev item in listOfItems)
            {
                if (item.Allowed == false && item.Checked == true)
                listBoxRequestAllow.Items.Add(item.Id + ". " + item.Title + ":\t" + item.Description + "\t-\tUserId: " + item.UserId);
            }
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            GetAllZahtev();
        }

        private void listBoxRequestAllow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRequestAllow.SelectedItem != null)
            {
                Zahtev zahtev = new Zahtev();
                string selectedRow = listBoxRequestAllow.SelectedItem.ToString();

                textBoxRequestAllow.Text = selectedRow.Substring(0, selectedRow.IndexOf(". "));

            }

        }

        private void buttonUserCheck_Click(object sender, EventArgs e)
        {
            List<Korisnik> KorisnikIdLista = new List<Korisnik>();
            int pom = 0;
            KorisnikIdLista = this.korisnikBusiness.GetAllKorisnik();
            foreach (Korisnik item in KorisnikIdLista)
            {
                if (item.Id == Convert.ToInt32(textBoxCheck.Text) && item.Role.Equals("Administrator"))
                {
                    labelAllow.Visible = true;
                    buttonAllow.Enabled = true;
                    labelCheck.Text = "Authority Confirmed, welcome administrator.";
                    MessageBox.Show("You confirmed your identity, select Request you want to filter!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pom++;
                }
            }
            if (pom == 0)
                MessageBox.Show("You choose UserId that doesn't exists or doesn't meet the requirements!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAllow_Click(object sender, EventArgs e)
        {
            List<Zahtev> ZahtevIdLista = new List<Zahtev>();
            int pom = 0;
            ZahtevIdLista = this.zahtevBusiness.GetAllZahtev();
            foreach (Zahtev item in ZahtevIdLista)
            {
                if (item.Id == Convert.ToInt32(textBoxRequestAllow.Text))
                {
                    item.Allowed = true;
                    string result = this.zahtevBusiness.UpdateZahtev(item);
                    MessageBox.Show("Odobrili ste dati zahtev!" ,"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pom++;
                }
            }
            if (pom == 0)
                MessageBox.Show("Neuspesno odobravanje!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GetAllZahtev();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm cf = new MainForm();
            cf.Visible = true;
        }
    }
}
