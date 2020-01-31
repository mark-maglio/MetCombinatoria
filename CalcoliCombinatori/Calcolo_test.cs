using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace CalcoliCombinatori
{
    [TestClass]
    public class Calcolo_Test
    {
        [TestMethod]
        public void Fattoriale()
        {
            int n = 5;
            long valore_calcolo = Calcolo.Fattoriale(n);
            long valore_aspettato = 120;
            Assert.AreEqual(valore_aspettato, valore_calcolo);
        }
        [DataTestMethod]
        [DataRow(5,120)]
        [DataRow(7,)]
    }
}
