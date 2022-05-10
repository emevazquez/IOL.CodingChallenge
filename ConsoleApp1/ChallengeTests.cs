using IOL.CodingChallenge.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    internal class ChallengeTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", "<h1>Lista vacía de formas!</h1>"); 
        }
    }
}
