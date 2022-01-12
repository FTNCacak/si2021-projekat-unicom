using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KorisnikBusiness
    {
        readonly KorisnikRepository korisnikRepository = new KorisnikRepository();

        public List<Korisnik> GetKorisnik()
        {
            return korisnikRepository.GetAllKorisnik().ToList();
        }

        public bool InsertProduct(Korisnik korisnik)
        {
            return korisnikRepository.InsertKorisnik(korisnik) != 0;
        }
    }
}
