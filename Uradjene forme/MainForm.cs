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
    public partial class MainForm : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;
        private readonly IZahtevBusiness zahtevBusiness;
        public MainForm()
        {
            InitializeComponent();
            IZahtevRepository zahtevRepository = new ZahtevRepository();
            this.zahtevBusiness = new ZahtevBusiness(zahtevRepository);
            IKorisnikRepository korisnikRepository = new KorisnikRepository();
            this.korisnikBusiness = new KorisnikBusiness(korisnikRepository);
        }
        private void GetAllZahtev()
        {
            listBoxOdobreniZahtevi.Items.Clear();

            List<Zahtev> listOfItems = this.zahtevBusiness.GetAllZahtev();

            foreach (Zahtev item in listOfItems)
            {
                if (item.Allowed == true)
                    listBoxOdobreniZahtevi.Items.Add(item.Id + ". " + item.Title + ":\t" + item.Description + "\t-\tUserId: " + item.UserId);
            }
        }

        private void buttonUserForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm cf = new UserForm();
            cf.Visible = true;
        }

        private void buttonRequestForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestForm cf = new RequestForm();
            cf.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllZahtev();
        }

        private void buttonMentorForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            MentorForm cf = new MentorForm();
            cf.Visible = true;
        }

        private void buttonAdministratorForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrationForm cf = new AdministrationForm();
            cf.Visible = true;
        }
    }
}
