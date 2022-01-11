using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnicomBusiness
{
    public class KorisnikBusiness : IKorisnikBusiness
    {
        private readonly IKorisnikRepository korisnikRepository;

        public KorisnikBusiness(IKorisnikRepository _korisnikRepository)
        {
            korisnikRepository = _korisnikRepository;
        }

        public List<Korisnik> GetAllKorisnik()
        {
            return this.korisnikRepository.GetAllKorisnik();
        }

        public string InsertKorisnik(Korisnik korisnik)
        {
            int rowsAffected = this.korisnikRepository.InsertKorisnik(korisnik);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }


        public string UpdateKorisnik(Korisnik korisnik)
        {
            int rowsAffected = this.korisnikRepository.UpdateKorisnik(korisnik);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena u bazi podataka!";
            }
            else
            {
                return "Neuspešna izmena, došlo je do greške!";
            }
        }

        public string DeleteKorisnik(int id)
        {
            int rowsAffected = this.korisnikRepository.DeleteKorisnik(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak iz baze podataka!";
            }
            else
            {
                return "Brisanje nije uspelo, došlo je do greške!";
            }
        }
    }
}
