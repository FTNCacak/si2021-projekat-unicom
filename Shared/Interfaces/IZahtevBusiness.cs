using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IZahtevBusiness
    {
        List<Zahtev> GetAllZahtev();
        string InsertZahtev(Zahtev zahtev);
        string UpdateZahtev(Zahtev zahtev);
        string DeleteZahtev(int id);
    }
}
