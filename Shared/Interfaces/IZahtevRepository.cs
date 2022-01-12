using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IZahtevRepository
    {
        List<Zahtev> GetAllZahtev();
        int InsertZahtev(Zahtev zahtev);
        int UpdateZahtev(Zahtev zahtev);
        int DeleteZahtev(int id);
    }
}
