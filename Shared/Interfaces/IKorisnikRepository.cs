using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IKorisnikRepository
    {
        List<Korisnik> GetAllKorisnik();
        int InsertKorisnik(Korisnik korisnik);
        int UpdateKorisnik(Korisnik korisnik);
        int DeleteKorisnik(int id);
    }
}
