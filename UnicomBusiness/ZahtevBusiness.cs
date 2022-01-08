using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomBusiness
{
    public class ZahtevBusiness : IZahtevBusiness
    {
        private readonly IZahtevRepository zahtevRepository;

        public ZahtevBusiness(IZahtevRepository _zahtevRepository)
        {
            zahtevRepository = _zahtevRepository;
        }

        public List<Zahtev> GetAllZahtev()
        {
            return this.zahtevRepository.GetAllZahtev();
        }

        public string InsertZahtev(Zahtev zahtev)
        {
            int rowsAffected = this.zahtevRepository.InsertZahtev(zahtev);

            if (rowsAffected > 0)
            {
                return "Uspešan unos zahteva u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos zahteva, došlo je do greške!";
            }
        }


        public string UpdateZahtev(Zahtev zahtev)
        {
            int rowsAffected = this.zahtevRepository.UpdateZahtev(zahtev);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena zahteva u bazi podataka!";
            }
            else
            {
                return "Neuspešna izmena zahteva, došlo je do greške!";
            }
        }

        public string DeleteZahtev(int id)
        {
            int rowsAffected = this.zahtevRepository.DeleteZahtev(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan zahtev iz baze podataka!";
            }
            else
            {
                return "Brisanje zahteva nije uspelo, došlo je do greške!";
            }
        }
    }
}
