using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseSwitch
{
    [TestClass]
    public class HowWasYourDay
    {
        [TestMethod]
        public void TestMethod1()
        {
            int mood = 5;
            switch (mood)
            {
                case 1:
                    Console.WriteLine("Great");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                    Console.WriteLine("Bad");
                    break;
                case 5:
                    Console.WriteLine(":(");
                    break;
            }
        }
    }
}
