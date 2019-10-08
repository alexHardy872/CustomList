using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {

        private T[] items;

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }


        public CustomList()
        {
            items = new T[4];
        }

        public CustomList<T> this[T index]
        {
            get
            {

            }
            set
            {

            }
        }







        // ADD
        public void Add(T itemToAdd)
        {



        }


        // REMOVE

        public void Remove(int indexToRemove) 
        {

        }

        // ZIP
        public void Zip(CustomList<T> listOne, CustomList<T> listTwo) // restrictor that lists are same T
        {
            // iterate through COUNT of ListOne + COUNT of ListTwo put together. // do zip lists have to be equal??
            // add listOne[0]
            // add listTwo[0]
            // add listOne [1]
            // add listTwo [1]
        }

















    }


}
