using System;
using Linear.Sequence;
using NUnit.Framework;

namespace Linear.Test
{
    public class SequenceListTest
    {
        private SequenceList<int> _list;
        [SetUp]
        public void Setup()
        {
            this._list = new SequenceList<int>();
        }

        [Test]
        public void InitListTest()
        {
            Assert.AreEqual(0, this._list.Length);
        }


        [Test]
        public void AppendTest()
        {
            this._list.Add(123);
            Assert.AreEqual(1, this._list.Length);
        }
        [Test]
        public void FindElementTest()
        {
            this._list.Add(1);
            this._list.Add(2);
            this._list.Add(3);
            this._list.Add(5);
            this._list.Add(4);

            Assert.AreEqual(4, this._list.Find(4));

        }

        [Test]
        public void RemoveTest()
        {
            this._list.Add(1);
            this._list.Add(2);
            this._list.Add(3);
            this._list.Add(5);
            this._list.Add(4);
            this._list.Remove(4);

            Assert.AreEqual(4, this._list.Length);
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