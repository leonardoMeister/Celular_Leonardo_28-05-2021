using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DatasLeonardo;


namespace DatasLeonardo.ConsoleApp
{
    [TestClass]
    public class TesteClassPeriodoPassado
    {
        [TestMethod]
        public void DeveRetornarCodigoEsperado()
        {
            Celular aux;
                           
            aux = new Celular("SEMPRE ACESSO O DOJOPUZZLES");
            string auxString = aux.Traducao;
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", auxString);

            aux = new Celular("LEEONARDO  MARGOTI MEISTER");
            auxString = aux.Traducao;
            Assert.AreEqual("55533_33666_66277736660_0627774666844406334447777833777", auxString);

            aux = new Celular("LEEONARDO  MARGOTI MEISTER");
            auxString = aux.Traducao;
            Assert.AreEqual("55533_33666_66277736660_0627774666844406334447777833777", auxString);
        }

        [TestMethod]
        public void DeveRetornarCodigoEsperadoEspacos()
        {
            Celular aux;

            aux = new Celular("  a  ");
            string auxString = aux.Traducao;
            Assert.AreEqual("0_020_0", auxString);           
        }

        [TestMethod]
        public void DeveRetornarCodigoEsperadoConsoantes()
        {
            Celular aux;

            aux = new Celular("bcdfghjklmnpqrstvwxz");
            string auxString = aux.Traducao;
            Assert.AreEqual("22_2223_3334_445_55_5556_667_77_777_77778_8889_99_9999", auxString);
        }

        [TestMethod]
        public void DeveRetornarCodigoEsperadoVogais()
        {
            Celular aux;

            aux = new Celular("aeiou");
            string auxString = aux.Traducao;
            Assert.AreEqual("23344466688", auxString);
        }
    }
}
