using Microsoft.VisualStudio.TestTools.UnitTesting;
using pc2x.Application.Repositories.Mappers;
using pc2x.Application.Repositories.Repositories;
using System.Linq;

namespace pc2x.Application.Tests.Repositories
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerLista_Paises()
        {
            AutoMapperConfiguration.Configure();
            var repo = new PaisRepository();
            var x = repo.GetAll();

            Assert.IsTrue(x.Any());
        }
    }
}
