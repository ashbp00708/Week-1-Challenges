using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operators
{
    [TestClass]
    public class operators
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numAge = 23;
            int numVar = 7;

            int sum = numAge + numVar;
            int diff = numAge - numVar;
            int prod = numAge * numVar;
            int quot = numAge / numVar;
            int remainder = numAge % numVar;
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(prod);
            Console.WriteLine(quot);
            Console.WriteLine(remainder);
            
        }
    }
}
