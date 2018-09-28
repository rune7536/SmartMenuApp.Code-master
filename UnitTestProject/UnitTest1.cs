using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;
using FunctionLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoThis()
        {
           Assert.AreEqual("Result from DoThis", Functions.DoThis());
        }
        [TestMethod]
        public void DoThat()
        {
            Assert.AreEqual("Result from DoThat", Functions.DoThat());
        }
        [TestMethod]
        public void DoSomething()
        {
            Assert.AreEqual("Result from doing: something", Functions.DoSomething("something"));
        }
        [TestMethod]
        public void GetTheAnswerToLifeTheUniverseAndEverything()
        {
            Assert.AreEqual(42, Functions.GetTheAnswerToLifeTheUniverseAndEverything());
        }

    }

}
