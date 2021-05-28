using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DatasLeonardo;

namespace DatasLeonardo.Test
{
    [TestClass]
    public class TesteClassPeriodoPassado
    {
        [TestMethod]
        public void DeveRetornarAnoMesSemanaDia()
        {
            PeriodoPassado aux;
            aux = new PeriodoPassado(new DateTime(2001, 08, 17));
            string auxString = aux.StringDataExtenso;
            Assert.AreEqual("Dezenove Anos, Nove Meses, Duas Semanas e Tres Dias", auxString);

            aux = new PeriodoPassado(new DateTime(2001, 07, 20));
            auxString = aux.StringDataExtenso;
            Assert.AreEqual("Dezenove Anos, Dez Meses, Duas Semanas e Um Dia", auxString);
        }
    }
}
