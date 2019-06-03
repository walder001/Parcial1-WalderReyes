using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_WalderReyes.BLL;
using Parcial1_WalderReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_WalderReyes.BLL.Tests
{
    [TestClass()]
    public class ProductoBLLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Inventario inventario = new Inventario();
            inventario.IdInventario = 1;
            inventario.Total = 0;
            paso = InventarioBLL.Guardar(inventario);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}