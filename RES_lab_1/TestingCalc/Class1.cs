using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RES_lab_1;
namespace TestingCalc
{
    public class Class1
    {
        [Test]
        public void TestSum()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(6, calcTest.sum(2, 4));
        }
        public void TestSum2()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(0, calcTest.sum(0, 0));
        }
        public void TestSum3()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(2, calcTest.sum(-2, 4));
        }
        public void TestMin()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(-2, calcTest.min(2, 4));
        }
        public void TestMin2()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(0, calcTest.min(0, 0));
        }
        public void TestMin3()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(-6, calcTest.min(-2, 4));
        }
        public void TestMlt()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(8, calcTest.mlt(2, 4));
        }
        public void TestMlt2()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(0, calcTest.mlt(0, 0));
        }
        public void TestMlt3()
        {
            Calc calcTest = new Calc();
            Assert.AreEqual(-8, calcTest.mlt(-2, 4));
        }
    }
}
