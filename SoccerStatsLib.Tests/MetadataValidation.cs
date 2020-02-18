using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoccerStatsLib.Tests
{
    [TestClass]
    public class MetadataValidation
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InvalidJersey()
        {
            var hapless = new Athlete(-7);
        }
        [TestMethod]
        public void InvalidHeight()
        {
            var stretch = new Athlete(37);
            stretch.Height = 548;
            var expected = true;
            Assert.AreEqual(expected, stretch.InvalidHeight);
        }
    }
}
