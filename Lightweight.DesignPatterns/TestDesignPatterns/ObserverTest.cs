using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lightweight.DesignPatterns.Observer;

namespace TestDesignPatterns
{
    [TestClass]
    public class ObserverTest
    {
        Subject subject = new Subject();

        private class Observer : IObserver
        {
            public int Counter = 0;
            public void Update()
            {
                this.Counter++;
            }
        }

        [TestMethod]
        public void TestSubscribe()
        {
            Assert.AreEqual(0, subject.Count);
            Observer observer = new Observer();
            this.subject.Subscribe(observer);
            Assert.AreEqual(1, subject.Count);
        }

        [TestMethod]
        public void TestUnsubscribe()
        {
            Observer observer = new Observer();
            this.subject.Subscribe(observer);
            Assert.AreEqual(1, this.subject.Count);
            this.subject.Unsubscribe(observer);
            Assert.AreEqual(0, this.subject.Count);
        }

        [TestMethod]
        public void NotifyTest()
        {
            Observer observer = new Observer();
            this.subject.Subscribe(observer);
            Assert.AreEqual(1, this.subject.Count);
            Assert.AreEqual(0, observer.Counter);
            this.subject.Notify();
            Assert.AreEqual(1, observer.Counter);
        }
    }
}
