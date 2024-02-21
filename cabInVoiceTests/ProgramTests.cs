using Microsoft.VisualStudio.TestTools.UnitTesting;
using cabInVoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void totalFairTest()
        {
            double distance = 2.0;
            int time = 5;
            double Expected = 25;
            double actual=Program.totalFair(distance,time);
            Assert.AreEqual(Expected,actual);
        }
    }
}