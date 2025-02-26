using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KorTDD1;
using System.Security.Cryptography.X509Certificates;
using KorTDD;
namespace KorrTDD_Teszt
{
    [TestClass]
    public class KorClass_Test
    {
        KorClass kor = new KorClass(4.00);
        [TestMethod]
        public void setKerulet_teszt_True()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.12,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void SetKerulet_teszt_False_Alatt()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.11,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void SetKerulet_teszt_False_Felett()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.13,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void setTerulet_teszt_True()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.12,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void SetTerulet_teszt_False_Alatt()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.11,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void SetTerulet_teszt_False_Felett()
        {
            double sugar = kor.getsugar();
            double vartEredm = 25.13,
                    kapottEredm;
            kapottEredm = kor.setKerulet(sugar);

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
    }
}