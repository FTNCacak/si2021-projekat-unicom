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

namespace Unicom
{
    public partial class Unicom : Form
    {
        readonly KorisnikBusiness korisnikBusiness = new KorisnikBusiness();
        public Unicom()
        {
            InitializeComponent();
        }

        private void Unicom_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            listBoxKorisniks.Items.Clear();
            foreach (Korisnik korisnik in korisnikBusiness.GetKorisnik())
            {
                string itemData = string.Format("{0}. {1}. {2}. {3}", korisnik.Id,korisnik.Username, korisnik.First_Name, korisnik.Last_Name);
                listBoxKorisniks.Items.Add(itemData);
            }
        }

        private void buttonInsertKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik()
            {
                Username = textBoxUsername.Text,
                First_Name = textBoxFirstName.Text,
                Last_Name = textBoxLastName.Text,
            };

            korisnikBusiness.InsertProduct(korisnik);

            RefreshList();

            textBoxUsername.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text  = "";
            textBoxYearofBirth.Text = "";
        }
    }
}
