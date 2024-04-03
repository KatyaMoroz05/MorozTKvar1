using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MorozTKvar1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.Result("10","50","30","10"));
            Assert.IsTrue(Program.Result("0","0","0","0"));
            Assert.IsTrue(Program.Result("5","30","10","3"));
            Assert.IsTrue(Program.Result("0000","000","00","0"));
            Assert.IsFalse(Program.Result("-10","-20","11","8"));
            Assert.IsFalse(Program.Result("30","50","100000","12"));
            Assert.IsFalse(Program.Result("","","",""));
            Assert.IsFalse(Program.Result("qwerty","20","10","10"));
            Assert.IsFalse(Program.Result("\n","\"","10","10"));
        }
    }
}
