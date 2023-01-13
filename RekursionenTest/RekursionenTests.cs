using Rekursionen;

namespace RekursionenTest
{
    public class RekursionenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fakultaet_EingabeEinerZahl_RichtigesErgebniss()
        {
            int ergebniss = Rekursion.Fakultaet(6);

            Assert.AreEqual(720, ergebniss);
        }

        [Test]
        public void Fakultaet_EingabeEinerNegativenZahl_RichtigesErgebniss()
        {
            int ergebniss = Rekursion.Fakultaet(-6);

            Assert.AreEqual(720, ergebniss);
        }

        [Test]
        public void Fibunacci_EingabeEinerZahl_RichtigesErgebniss()
        {
            int ergebniss = Rekursion.Fibunacci(6);

            Assert.AreEqual(8, ergebniss); 
        }

        [Test]
        public void Fibunacci_EingaberEinerNegativenZahl_ErgebnissIstNull()
        {
            int ergebniss = Rekursion.Fibunacci(-6);

            Assert.AreEqual(0, ergebniss);
        }
    }
}