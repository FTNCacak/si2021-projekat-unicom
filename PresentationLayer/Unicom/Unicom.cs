using MagacinBusiness;
using MagacinData;
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

namespace Magacin
{
    public partial class Unicom : Form
    {
        private readonly IKorisnikBusiness korisnikBusiness;

        public Unicom(IKorisnikBusiness _korisnikBusiness)
        {
            korisnikBusiness = _korisnikBusiness;
            InitializeComponent();
        }

        private void Magacin_Load(object sender, EventArgs e)
        {
            GetAllKorisnik();
        }

        private void GetAllKorisnik()
        {
            listBoxKorisnik.Items.Clear();

            List<Korisnik> listOfKorisnik = this.korisnikBusiness.GetAllKorisnik();

            foreach (Korisnik korisnik in listOfKorisnik)
            {
                listBoxKorisnik.Items.Add(korisnik.Username + ":\t" + korisnik.First_Name + "\t-\t" +korisnik.Last_Name );
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_itemInsert_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();

            korisnik.Username = textBox_KorisnikUsername.Text;
            korisnik.First_Name = textBox_KorisnikFirstName.Text;
            korisnik.Last_Name = textBox_KorisnikLastName.Text;

            label_insertConfirm.Text = this.korisnikBusiness.InsertKorisnik(korisnik);

            textBox_KorisnikFirstName.Text = "";
            textBox_KorisnikLastName.Text = "";

            textBox_KorisnikUsername.Clear();

            GetAllKorisnik();
        }
    }
}
