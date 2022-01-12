using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Linq;
using UnicomBusiness;
using UnicomData;

namespace UnicomTestsFiles
{
    [TestClass]
    public class KorisnikTests
    {
        private Mock<IKorisnikRepository> mockKorisnikRepository = new Mock<IKorisnikRepository>();
        private KorisnikBusiness korisnikBusiness;
        private KorisnikRepository korisnikRepository;
        private Korisnik korisnik = new Korisnik();
        [TestMethod]
        [TestInitialize]
        public void init()
        {
            korisnik = new Korisnik()
            {
                Username = "testuser22",
                First_Name = "Test",
                Last_Name = "User",
                Role = "User",
                Gender = "Male"
            };
            korisnikRepository = new KorisnikRepository();
        }
        public void GetKorisnikTest()
        {
            korisnikRepository.InsertKorisnik(korisnik);
            Assert.IsNotNull(korisnikRepository.GetAllKorisnik());
        }

        [TestMethod]
        public void UpdateKorisnikTest()
        {
            korisnikRepository.InsertKorisnik(korisnik);
            Korisnik newKorisnik = korisnikRepository.GetAllKorisnik().Where(x => x.Username == korisnik.Username).ToList()[0];
            int result = korisnikRepository.UpdateKorisnik(newKorisnik);
            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void CheckDeleteKorisnik()
        {
            Korisnik newKorisnik = korisnikRepository.GetAllKorisnik().Where(x => x.Username == korisnik.Username).ToList()[0];
            korisnikRepository.DeleteKorisnik(newKorisnik.Id);
        }
    }
}
