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
    public partial class MentorForm : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;
        private readonly IZahtevBusiness zahtevBusiness;
        public MentorForm()
        {
            InitializeComponent();
            IZahtevRepository zahtevRepository = new ZahtevRepository();
            this.zahtevBusiness = new ZahtevBusiness(zahtevRepository);
            IKorisnikRepository korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness(korisnikRepository);
        }
        private void MentorForm_Load(object sender, EventArgs e)
        {
            GetAllZahtev();
        }
        private void GetAllZahtev()
        {
            listBoxRequestFilter.Items.Clear();

            List<Zahtev> listOfItems = this.zahtevBusiness.GetAllZahtev();

            foreach (Zahtev item in listOfItems)
            {
                if(item.Checked == false)
                listBoxRequestFilter.Items.Add(item.Id + ". " + item.Title + ":\t" + item.Description + "\t-\tUserId: " + item.UserId);
            }
        }
        private void buttonUserCheck_Click(object sender, EventArgs e)
        {

            List<Korisnik> KorisnikIdLista = new List<Korisnik>();
            int pom = 0;
            KorisnikIdLista = this.korisnikBusiness.GetAllKorisnik();
            foreach (Korisnik item in KorisnikIdLista)
            {
                if (item.Id == Convert.ToInt32(textBoxCheck.Text) && (item.Role.Equals("Mentor") || item.Role.Equals("Administrator")))
                {
                    labelFilter.Visible = true;
                    buttonFilter.Enabled = true;
                    labelCheck.Text = "Authority Confirmed, you are allowed to proceed.";
                    MessageBox.Show("You confirmed your identity, select Request you want to filter!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pom++;
                }
            }
            if (pom == 0)
                MessageBox.Show("You choose UserId that doesn't exists or doesn't meet the requirements!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            List<Zahtev> ZahtevIdLista = new List<Zahtev>();
            int pom = 0;
            ZahtevIdLista = this.zahtevBusiness.GetAllZahtev();
            foreach (Zahtev item in ZahtevIdLista)
            {
                if (item.Id == Convert.ToInt32(textBoxRequestFilter.Text))
                {
                    
                    item.Checked = true;
                    string result = this.zahtevBusiness.UpdateZahtev(item);
                MessageBox.Show("You have sent the request to the admninistration!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pom++;
                    //labelTest.Text = item.Checked.ToString();
                }
            }
            if (pom == 0)
                MessageBox.Show("Filter is not successfully done!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GetAllZahtev();
        }

        private void listBoxRequestFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRequestFilter.SelectedItem != null)
            {
                Zahtev zahtev = new Zahtev();
                string selectedRow = listBoxRequestFilter.SelectedItem.ToString();

                textBoxRequestFilter.Text = selectedRow.Substring(0, selectedRow.IndexOf(". "));

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm cf = new MainForm();
            cf.Visible = true;
        }
    }
}
