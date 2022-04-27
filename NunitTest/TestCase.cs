using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace NunitTest
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void User()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual("FakhriAbdillah", mtk.User("Fakhri"));
        }

        [TestCase]
        public void Tambah()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(31, mtk.Tambah(20, 11));

        }

        [TestCase]
        public void Kurang()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(9, mtk.Kurang(20, 11));

        }


    }
}
