using NUnit.Framework;
using System;
using Linear.Linked;
using System.Text;

namespace Linear.Test
{
    class LinkedListTest
    {
        private LinkedList<int> _list;
        [SetUp]
        public void Setup()
        {
            this._list = new LinkedList<int>();
        }


        [Test]
        public void IsEmptyTest() 
        {
            Assert.IsTrue(this._list.IsEmpty());
        }

        [Test]
        public void AppendTest()
        {
            this._list.Add(1);
            Assert.AreEqual(1, this._list.Length);
        }

        [Test]
        public void RemoveTest()
        {
            this._list.Add(1);
            this._list.Add(2);
            this._list.Add(3);
            this._list.Add(4);
            this._list.Add(5);
            this._list.Remove(4);
            Assert.AreEqual("1,2,3,5", this._list.ToString());
        }

        [Test]
        public void IndexTest()
        {
            this._list.Add(1);
            this._list.Add(2);
            this._list.Add(3);
            this._list.Add(5);
            this._list.Add(4);

            Assert.AreEqual(3, this._list[2]);
            this._list[2] = 6;
            Assert.AreEqual(6, this._list[2]);
        }
    }
}
