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


            CustomList<int> testList = new CustomList<int>() { 1, 2, 4 };

            CustomList<int> testList2 = new CustomList<int>();

            CustomList<int> testList3 = new CustomList<int>();

            testList3.Add(1);
            testList3.Add(3);
            testList3.Add(5);

            testList3.Add(2);
            testList3.Add(4);
            testList3.Add(6);

            testList.Add(1);
            testList.Add(3);
            //testList.Add(5);

            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);

            CustomList<int> zipped = testList.Zip(testList2);
            Console.WriteLine(zipped[0]);
            Console.WriteLine(zipped[1]);
            Console.WriteLine(zipped[2]);
            Console.WriteLine(zipped[3]);
         
            
            foreach(int item in zipped)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();







        }
    }
}
