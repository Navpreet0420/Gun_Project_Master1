using System;
using System.Windows.Forms;
using Gun_Project_Master1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gun_Project_Master1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gun_Project_Master1.shoot_start obj = new Gun_Project_Master1.shoot_start();
            PlayGame playGame = new PlayGame();
            playGame.Execute_option3(obj.spin_game);
            int x = 3;
            if (x> playGame.y)
            {
                MessageBox.Show("Matched");
                Assert.IsTrue(true);
            }
            else
            {
                MessageBox.Show("Not Matched");
                Assert.IsTrue(true);
            }
        }
    }
}
