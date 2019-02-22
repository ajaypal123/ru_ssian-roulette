using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ru_ssian_roulette
{
    class Test
    { //this is the test 
        spin spine = new spin();
        [TestCase]
        public void pos()
        {

            Assert.AreEqual(5, spine.sp(4));
        }

        [TestCase]
        public void neg()
        {

            Assert.AreNotEqual(7, spine.sp(6));
        }
    }
}
