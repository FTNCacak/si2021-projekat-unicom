﻿using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IKorisnikBusiness
    {
        List<Korisnik> GetAllKorisnik();
        string InsertKorisnik(Korisnik korisnik);
        string UpdateKorisnik(Korisnik korisnik);
        string DeleteKorisnik(int id);
    }
}
