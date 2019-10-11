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






           

            List<string> testList = new List<string>() { "Computer", "Zebra", "Apple", "Demon", "Lizard", "Rock", "Seltzer", "Boron", "King", "Jack", "Pumpkin", "Quite", "Velociraptor", "Walleye", "Xenu" };
            testList.Sort();

            foreach(string word in testList){
                Console.WriteLine(word);
            }
            int index = testList.BinarySearch("Apple");
            Console.WriteLine( "found "+testList[0]+" at "+ index);


            int test = 5 / 2;
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
