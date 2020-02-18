using System;
using SoccerStatsLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoccerStatsLib.Tests
{
    [TestClass]
    public class RoleRelated
    {
        [TestMethod]
        public void InitialPositionUnknown()
        {
            var player = new Athlete(8);
            var actual = player.Position.Role;
            var expected = BasicRole.Unknown;
            Assert.AreEqual(expected, actual);


        }
    }
}
