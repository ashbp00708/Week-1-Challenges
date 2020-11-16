using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conditionals
{
    [TestClass]
    public class Conditionals
    {
        [TestMethod]
        public void HoursofSleep()
        {
            int h = 8;

            if (h>=10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (10 > h && h >= 8) 
            {
                Console.WriteLine("You should be pretty well rested");
            }
            else if (8>h & h>4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

        }


    }
}
