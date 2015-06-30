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

        [TestMethod]
        public void ICanAddAnElement_ThenICanGetItBack()
        {
            var four = 4;
            var set = new Set(1);
            set.Add(four);
            Assert.AreEqual(four, set.Get());
        }

        [TestMethod]
        public void IfIAddOneElement_ThenItShouldBeNotEmpty()
        {
            var four = 4;
            var set = new Set(1);

            Assert.IsTrue(set.IsEmpty());
            set.Add(four);
            Assert.IsFalse(set.IsEmpty());
        }


    }
}
