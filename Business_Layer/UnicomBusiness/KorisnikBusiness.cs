using MagacinData;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinBusiness
{
    public class KorisnikBusiness : IKorisnikBusiness
    {
        private readonly Shared.Interfaces.IKorisnikRepository korisnikRepository;

        public KorisnikBusiness(Shared.Interfaces.IKorisnikRepository _korisnikRepository)
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
    }
}
