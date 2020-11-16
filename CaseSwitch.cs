using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseSwitch
{
    class CaseSwitch
    {
        static void Main(string[] args)
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

