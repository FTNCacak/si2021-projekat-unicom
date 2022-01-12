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
    public class ZahtevTests
    {
        private Mock<IZahtevRepository> mockZahtevRepository = new Mock<IZahtevRepository>();
        private ZahtevBusiness zahtevBusiness;
        private ZahtevRepository zahtevRepository;
        private Zahtev zahtev = new Zahtev();
        [TestMethod]
        [TestInitialize]
        public void init()
        {
            zahtev = new Zahtev()
            {
                Title = "TestTitle",
                Description = "Description for TestTitle",
                UserId = 1111,
                Checked = false,
                Allowed = false
            };
            zahtevRepository = new ZahtevRepository();
        }

        public void GetZahtevTest()
        {
            zahtevRepository.InsertZahtev(zahtev);
            Assert.IsNotNull(zahtevRepository.GetAllZahtev());
        }

        [TestMethod]
        public void UpdateZahtevTest()
        {
            zahtevRepository.InsertZahtev(zahtev);
            Zahtev newZahtev = zahtevRepository.GetAllZahtev().Where(x => x.Title == zahtev.Title).ToList()[0];
            int result = zahtevRepository.UpdateZahtev(newZahtev);
            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void CheckDeleteZahtev()
        {
            Zahtev newZahtev = zahtevRepository.GetAllZahtev().Where(x => x.Title == zahtev.Title).ToList()[0];
            zahtevRepository.DeleteZahtev(newZahtev.Id);
        }
    }
}
