﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {


        public IEnumerator<T> GetEnumerator()
        {    
            
            for ( int i = 0; i < count; i++)
            
            {
                if (items[i] == null)
                {
                    break;
                }
                
                    yield return items[i];              
            }       
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            // Lets call the generic version here
            return this.GetEnumerator();
        }





        private T[] items;

        public T this[int index]

        {
            get
            {
                // return the value specified by index
                T temp;

                if (index >= 0 && index < count)
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
                if (index >= 0 && index < capacity)
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
            int newSize = capacity * 2;
            T[] larger = new T[newSize];

            for (int i = 0; i < items.Length; i++)
            {
                larger[i] = items[i];
            }

            items = larger;
            Capacity = capacity * 2;
        }


        //   //    //   //   //   //   //  //  //  //  //  //  // ADD METHODES


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


        public bool AddAt(T itemToAdd, int index)
        {
            if (count == 0 || index == count)
            {
                Add(itemToAdd);
                return true;
            }
            if (index > count || index <0) // check that index is within count
            {
                return false;
            }
            if (count == capacity)
            {
                GrowArray();
            }
            bool added = false;
            T[] larger = new T[capacity];

            for ( int i = 0; i < count; i++)
            {
                if (added == false)
                {
                    if ( i == index)
                    {
                        larger[i] = itemToAdd;
                        incrementCount();
                        added = true;
                    }
                    else
                    {
                        larger[i] = items[i];

                    }
                }
                else // added = true
                {
                    larger[i] = items[i - 1];
                }
            }

            items = larger;
            return true;

        }


        //  //   //    //    //    ///    //   //  //  //  //  //  REMOVE METHODES




        public bool Remove(T valueToRemove)
        {
            for ( int i = 0; i < count; i++)
            {
                if ( items[i].Equals(valueToRemove))
                {                                           ///////////// BUG
                    DecrementCount();
                 
                    for ( int j = i; j < count+1; j++)
                    {
                        if (j == count)
                        {
                            break;
                        }
                        items[j] = items[j+1];
                    }
                    return true;
                }
                else
                {
                    items[i] = items[i];
                }
            }
            return false;
        }
      
       

        public bool RemoveAt(int index)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    DecrementCount();
                    for (int j = i; j < count+1; j++)
                    {
                        if (j == count)
                        {
                            break;
                        }
                        items[j] = items[j + 1];
                    }
                    return true;
                }
                else
                {
                    items[i] = items[i];
                }
            }    
            return false;
        }

        public void RemoveAll(T valueToRemove)
        {
            bool removed;
            do
            {
                removed = Remove(valueToRemove);
            }
            while (removed == true);
        }


        private void DecrementCount()
        {
            count -= 1;
        }



        // ZIP
        public CustomList<T> Zip( CustomList<T> newList) 
        {
            CustomList<T> zipped = new CustomList<T>();
            int zipCount = GetShortestCountOfTwoLists(newList);
            for ( int i = 0; i < zipCount; i ++ )
            {
               
                zipped.Add(items[i]);
                zipped.Add(newList[i]);
            }
            return zipped;
        }

        private int GetShortestCountOfTwoLists(CustomList<T> list2)
        {
            if (count > list2.Count)
            {
                return list2.Count;
            }
            else
            {
                return count;
            }
        }

        
        public override string ToString() 
        {
            string result = "[";
            for ( int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    result += items[i].ToString() + "]";
                    break;
                }
                else
                {
                    result += items[i].ToString() + ", ";                   
                }
            }      
            return result;
        }
        



        public bool Contains(T check)
        {
            for ( int i = 0; i < count; i++)
            {
                if (items[i].Equals(check))
                {
                    return true;
                }

            }
         
            return false;
        }

        public int IndexOf(T check) // returns first index of check
        {
          for(int i = 0; i < count; i++)
            {
                if (items[i].Equals(check))
                {
                    return i;
                }
            }

            return -1;
        }


        //////// // // // // // // // // // // //  // // // // // // / // // OPERATOR OVERLOADS


        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> sum = new CustomList<T>();
            foreach (T item in listOne)
            {
                sum.Add(item);
            }
            foreach (T item in listTwo)
            {
                sum.Add(item);
            }
            return sum;
        }


        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> sum = new CustomList<T>();
            CustomList<T> temp = new CustomList<T>();     
            temp = listTwo;
            foreach (T item in listOne)
            {
                if ((temp.Contains(item)) == true)
                {

                    temp.Remove(item);
                }
                else
                {
                    sum.Add(item);
                }
            }
            return sum;    
        }

        /*
        public void Sort()  where T : CustomList<int>
        {
           
            
            for (int i = 0; i < count; i++)
            {
                if (Compare(i, i+1) == true)
                {
                    Swap(i, i + 1);
                }



            } */

            // Loop through array
                
            // for each item, loop through items UNTIL it finds an item lower, else put at end 
                // check item and item+1, if item higher switch their index

            // loop through again, if nothing switched stop

           
       // }

        public CustomList<int> SortLargestFirst(CustomList<int> Items, int mobileCount, int start)
        {
            int largest;

            for (int i = start; i < mobileCount; i++)
            {       
                if (i == mobileCount -1 )
                {
                    break;
                }

                if (Compare2(i, mobileCount - 1, Items) == true)
                {
                    largest = Items[i];
                    Items.RemoveAt(i);
                    Items.AddAt(largest, mobileCount-1);
                }
            }
            return Items;
        }

        public CustomList<int> SortSmallest(CustomList<int> Items, int mobileCount, int start)
        {  
            if (mobileCount == start)
            {
                return Items;
            }
            for (int i = mobileCount-1; i > start; i--)
            {
                if (Compare2(i, start, Items) == false)
                {
                    int smallest = Items[i];
                    Items.RemoveAt(i);
                    Items.AddAt(smallest, start);
                }
            }
            return Items;
        }

        public bool Compare2(int item1, int item2, CustomList<int> Items) 
        {
            if (Items[item1] - Items[item2] >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CustomList<int> SortCombined(CustomList<int> Items, int mobileCount, int start )
        {
            if (mobileCount == start+1)
            {
                return Items;
            }
            Items = Items.SortLargestFirst(Items, mobileCount, start);
            Items = Items.SortSmallest(Items, mobileCount, start);
            return SortCombined(Items, mobileCount - 1, start + 1);
        }


        // if larger than largest move to end
        // if smaller than smallest move to start





    }


}
