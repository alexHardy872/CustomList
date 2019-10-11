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
            CustomList<string> testList = new CustomList<string>() { "p","o" };
            CustomList<string> testList2 = new CustomList<string>() { "o", "p"};

            CustomList<int> testList3 = new CustomList<int>() {  4, 4 };



            // int actual = (testList - testList2).Count;
            CustomList<string> result =  testList.Zip(testList2);

            Console.WriteLine(result.ToString());
            //Console.WriteLine(testList.Count);
            Console.ReadLine();


        }
    }
}
