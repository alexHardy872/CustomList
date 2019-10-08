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
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            Console.WriteLine(customList[0]);
            Console.WriteLine(customList[1]);
            Console.WriteLine(customList[2]);
            Console.WriteLine(customList[3]);
            Console.WriteLine(customList[4]);
            Console.WriteLine(customList[5]);
            Console.WriteLine(customList[6]);
            Console.WriteLine(customList[7]);
            Console.WriteLine(customList[8]);
            Console.ReadLine();






        }
    }
}
