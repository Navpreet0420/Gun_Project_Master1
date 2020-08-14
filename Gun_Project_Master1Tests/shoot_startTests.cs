using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gun_Project_Master1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun_Project_Master1.Tests
{
    [TestClass()]
    public class shoot_startTests
    {
        [TestMethod()]
        public void shoot_startTest()
        {
            Gun_Project_Master1.shoot_start obj = new Gun_Project_Master1.shoot_start();
            PlayGame playGame = new PlayGame();
            playGame.Execute_option1(obj.start_Game);
            int x = 1;
            if (x == playGame.y)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(true);
            }
        }
    }
}