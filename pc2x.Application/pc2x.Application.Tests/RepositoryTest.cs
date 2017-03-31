using Microsoft.VisualStudio.TestTools.UnitTesting;
using pc2x.Application.Repositories.Mappers;
using pc2x.Application.Repositories.Repositories;
using System.Linq;

namespace pc2x.Application.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void REPO_ObtenerLista_Paises()
        {
            AutoMapperConfiguration.Configure();
            var repo = new PaisRepository();
            var x = repo.GetAll();

            Assert.IsTrue(x.Any());
        }
    }
}
