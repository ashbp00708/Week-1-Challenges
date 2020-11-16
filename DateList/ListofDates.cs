using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateList
{
    [TestClass]
    public class ListofDates
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<DateTime> listofDates = new List<DateTime>();
            listofDates.Add(DateTime.Now);
            Console.WriteLine();
            Console.ReadLine();
           
          }  
    }
}
