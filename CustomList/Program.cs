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






           

            //List<string> testList = new List<string>() { "Computer", "Zebra", "Apple", "Demon", "Lizard", "Rock", "Seltzer", "Boron", "King", "Jack", "Pumpkin", "Quite", "Velociraptor", "Walleye", "Xenu" };
            //testList.Sort();

            //foreach(string word in testList){
            //    Console.WriteLine(word);
            //}
            //int index = testList.BinarySearch("Apple");
            //Console.WriteLine( "found "+testList[0]+" at "+ index);


            //int test = 5 / 2;
            //Console.WriteLine(test);
            //Console.ReadLine();



           
            CustomList<int> testList = new CustomList<int>();
            for (int i = 1; i <= 100; i++)
            {

                if (i < 50)
                {
                    testList.Add(i);
                }
                else if (i % 2 != 0)
                {
                    testList.Add(i);
                }
            }

            //CustomList<int> testList2 = new CustomList<int>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        testList2.Add(i);
            //    }
            //}

            //for (int i = 0; i < testList2.Count; i++)
            //{
            //    int index = testList.BinarySearch<int>(testList2[i]);
            //    testList.AddAt(testList2[i], index);
            //}

            int target = 56;
            int index = testList.BinarySearch<int>(target);
            testList.AddAt(target, index);
            Console.WriteLine("Added " + testList[index] + " between " + testList[index - 1] + " and " + testList[index + 1]);

            Console.ReadLine();
        }
    }
}
