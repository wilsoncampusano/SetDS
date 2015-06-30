using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SetDS_Implementation;

namespace SetDS
{
    [TestClass]
    public class WithASet
    {
        [TestMethod]
        public void ICanCreateOneWithACapacity()
        {
            var capacity = 10;
            Set set = new Set(capacity);
            Assert.AreEqual(capacity, set.Capacity);
        }
    }
}
