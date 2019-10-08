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


        public void AddAt(T itemToAdd , int index)
        {
            if (count == capacity)
            {
                GrowArray();
            }
            items[index] = itemToAdd;
            incrementCount(); // MAKE OTHER VALUES SHIFT AROUND
        }

     



        // REMOVE

        public bool Remove(T valueToRemove) 
        {
            if (count == 0)
            {
                return false;
            }
         
            int counter = 0;
            T[] smaller = new T[capacity];

            for ( int i = 0; i < count; i++)
            {

                if ( items[i].Equals(valueToRemove) && counter == 0)
                {
                    counter += 1;
                    
                    continue;
                }

                if (i == count - 1 && counter == 0)
                {
                    if (counter == 0)
                    {
                        return false; // NOT IN THIS LIST
                    }
                    else
                    {

                        items = smaller;
                        DecrementCount();
                        return true;
                    }

                }

                if (counter == 1)
                {
                    smaller[i-1] = items[i];
                    if ( i == count - 1)
                    {
                        items = smaller;
                        DecrementCount();
                        return true;
                    }
                }
                else
                {
                    smaller[i] = items[i];
                }
               

            }

            
            return false;
          
        }

       


        public bool RemoveAt(int index)
        {
            if (count == 0)
            {
                return false;
            }

            int counter = 0;
            T[] smaller = new T[capacity];

            for (int i = 0; i < count; i++)
            {

                if (i == index && counter == 0)
                {
                    counter += 1;

                    continue;
                }

                if (i == count - 1 && counter == 0)
                {
                    if (counter == 0)
                    {
                        return false; // NOT IN THIS LIST
                    }
                    else
                    {

                        items = smaller;
                        DecrementCount();
                        return true;
                    }

                }

                if (counter == 1 && i != 1)
                {
                
                
                    smaller[i - 1] = items[i];
                    if (i == count - 1)
                    {
                        items = smaller;
                        DecrementCount();
                        return true;
                    }
                }
                else
                {
                    smaller[i] = items[i];
                }


            }


            return false;



        }

        private void DecrementCount()
        {
            count -= 1;
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
