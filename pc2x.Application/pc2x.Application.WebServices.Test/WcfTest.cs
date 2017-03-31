using Microsoft.VisualStudio.TestTools.UnitTesting;
using pc2x.Application.Core.DomainModels;
using pc2x.Application.WebServices.WCF;
using System;
using System.Linq;
using System.ServiceModel;

namespace pc2x.Application.WebServices.Test
{
    [TestClass]
    public class WcfTest
    {
        private ChannelFactory<IPaisContract> _factory;

        private IPaisContract GetProxy()
        {
            _factory = new ChannelFactory<IPaisContract>(
               new WSHttpBinding(),
               "http://localhost:61416/ApplicationService.svc");

            return _factory.CreateChannel();
        }

        private void CloseProxy()
        {
            _factory.Close();
        }

        [TestMethod]
        public void WCF_GetAll_Paises()
        {
            try
            {
                var proxy = GetProxy();

                var x = proxy.GetAll();

                Assert.IsTrue(x.Any());
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                _factory.Close();
            }
        }

        [TestMethod]
        public void WCF_Add_Paises()
        {
            try
            {
                var proxy = GetProxy();
                var x = proxy.AddAsync(new PaisModel
                {
                    Codigo = "USA",
                    Nombre = "Estados Unidos"
                });

                x.Wait();

                Assert.IsTrue(x.Result.Id > 0);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                _factory.Close();
            }
        }


    }
}
