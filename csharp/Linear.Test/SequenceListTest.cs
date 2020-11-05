using System;
using Linear.Sequence;
using NUnit.Framework;

namespace Linear.Test
{
    public class SequenceListTest
    {
        private SequenceList<int> _sequence;
        [SetUp]
        public void Setup()
        {
            this._sequence = new SequenceList<int>();
            this._sequence.InitList();
        }

        [Test]
        public void InitListTest()
        {
            this._sequence.InitList();
            Assert.AreEqual(0,this._sequence.GetLength());
        }
        
        [Test]
        public void AppendTest()
        {
            this._sequence.Append(123);
            Assert.AreEqual(1,this._sequence.GetLength());
        }
    }


}