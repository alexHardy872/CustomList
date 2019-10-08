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


            CustomList<int> customList =  new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            Console.WriteLine(customList[0]);
            Console.WriteLine(customList[1]);
            Console.WriteLine(customList[2]);
            Console.ReadLine();




        }
    }
}
