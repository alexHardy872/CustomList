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

        public T this[int index]
        {
            get
            {
                // return the value specified by index
                T temp;

                if (index >= 0 && index <= capacity - 1)
                {
                    temp = items[index];
                    
                }
                else
                {
                    throw new System.ArgumentException("Index out of range");
                }

                return (temp);
            }
            set
            {
                // set the value specified by index
                if (index >= 0 && index <= capacity - 1)
                {
                    items[index] = value;
                }
            }
        }


        private int count;
        public int Count
        {
            get
            {
                return count;
            }
         
        }

        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }


        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

     
        public void GrowArray()
        {
            // make new array with double capacity
            // capacity *= 2
            // store new array as array (reference)

            int newSize = capacity * 2;
            T[] larger = new T[newSize];

            //iterate through old array and copy to new

            for ( int i = 0; i < items.Length; i++ )
            {
                larger[i] = items[i];
            }

            items = larger;
            Capacity = capacity * 2;
            
        }






        // ADD
        public void Add(T itemToAdd)
        {
           if (count == capacity)
            {
                GrowArray();
            }


            items[count] = itemToAdd;

            incrementCount();

        }

        private void incrementCount()
        {
            count += 1;
        }


        // REMOVE

        public void Remove(int indexToRemove) 
        {
            if (count == 0)
            {
                throw new System.ArgumentException("List is Empty, none to remove");
            }



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
