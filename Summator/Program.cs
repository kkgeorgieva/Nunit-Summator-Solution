using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Summator summator =  new Summator();
           int result = summator.Sum(new int[] { 1, 2, 3, 4, 5, 6});
            if (result == 21)
            {
                Console.WriteLine("Test passed!");
            }
            else {
                Console.WriteLine("Test failed!");
            }
        }
    }
}
