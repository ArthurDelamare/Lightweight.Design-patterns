using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lightweight.DesignPatterns.ObjectPool;

namespace TestDesignPatterns
{
    [TestClass]
    public class ObjectPoolTest
    {
        private class Person
        {
            public string Name { get; set; }
        }

        ObjectPool<Person> objectPool;

        [TestInitialize]
        public void SetUp()
        {
            objectPool = new ObjectPool<Person>(size: 3);
        }

        [TestMethod]
        public void GetTest()
        {
            Person person = objectPool.Get();
            Assert.IsNotNull(person);
            Assert.IsInstanceOfType(person, typeof(Person));
        }

        [TestMethod]
        public void ReleaseTest()
        {
            Person person = objectPool.Get();
            Assert.IsNotNull(person);
            objectPool.Release(person);
        }

        [TestMethod]
        public void CountTest()
        {
            Person person = objectPool.Get();
            Assert.IsNotNull(person);
            Assert.AreEqual(1, objectPool.Count);
        }
    }
}
