using Microsoft.VisualStudio.TestTools.UnitTesting;
using pc2x.Application.Repositories.Repositories;
using pc2x.Application.Services.Services;
using System.Linq;

namespace pc2x.Application.Tests
{
    [TestClass]
    public class ServicesTest
    {
        [TestMethod]
        public void SERV_ObtenerLista_Paises()
        {
            var serv = new PaisServicio(new PaisRepository());
            var x = serv.GetAll();

            Assert.IsTrue(x.Any());
        }
    }
}
