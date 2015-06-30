﻿using System;
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
            Assert.IsNotNull(set);
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

        [TestMethod]
        public void ICanAddMoreThanOneElement()
        {
            var four = 4; 
            var five = 5;
            var set = new Set(2);
            
            set.Add(four);
            Assert.AreEqual(1, set.Capacity);
            set.Add(five);
            Assert.AreEqual(2, set.Capacity);
        }

        [TestMethod]
        public void IfIAddFiveFour_ThenIShoulbGetFourFive()
        {
            var four = 4;
            var five = 5;
            var set = new Set(2);

            set.Add(five);
            set.Add(four);
            Assert.AreEqual(four, set.Get());
            Assert.AreEqual(five, set.Get());
        }

        [TestMethod]
        public void ICanAddTheNumbersOfElementsSpecifiedInConstructor()
        {
            var set = new Set(5);

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);

            Assert.AreEqual(5, set.Get());
            Assert.AreEqual(4, set.Get());
            Assert.AreEqual(3, set.Get());
            Assert.AreEqual(2, set.Get());
            Assert.AreEqual(1, set.Get());
       }

        [TestMethod]
        public void IfITryAddTheSameNumberManyTimes_ThenItShouldNotBeAdded()
        {
            var four = 4;
            var set = new Set(2);

            set.Add(four);
            set.Add(four);

            Assert.IsFalse(set.IsEmpty());
            Assert.AreEqual(0, set.Get());
            Assert.AreEqual(four, set.Get());
        }
    }
}
