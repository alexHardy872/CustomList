using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {






            // arrange
            CustomList<int> testList = new CustomList<int>() { 1, 2, 4, 4, 4, 6 };
            CustomList<int> testList2 = new CustomList<int>() { 4, 4 };

           
          
            int actual = (testList - testList2).Count;

            Console.WriteLine(actual);




        }
    }
}
