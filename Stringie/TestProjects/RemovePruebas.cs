using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stringie;

namespace TestProjects
{
    [TestClass]
    public class RemovePruebas
    {
        [TestMethod]
        public void Remove_LaMismaCadenaDeEntrada_Retornavacio()
        {
            var str = "12345";
            var removed = str.Remove("12345");
            Assert.AreEqual("", removed);


        }
    }
}
