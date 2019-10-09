using System;
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

                if (index >= 0 && index <= count - 1)
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
            if (count == 0)
            {
                return false;
            }
            bool removed = false;
            T[] smaller = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (removed == false)
                {
                    if (items[i].Equals(valueToRemove))
                    {
                        if (i == count - 1)
                        {
                            items = smaller;
                            DecrementCount();
                            return true;
                        }
                        removed = true;
                        continue;
                    }
                    else
                    {
                        smaller[i] = items[i];
                        if (i == count - 1)
                        {
                            return false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else  // IF REMOVED IS TRUE
                {
                    smaller[i - 1] = items[i];
                    if (i == count - 1)
                    {
                        items = smaller;
                        DecrementCount();
                        return true;
                    }

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
            bool removed = false;
            T[] smaller = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (removed == false)
                {
                    if (i == index)
                    {
                        if (i == count - 1)
                        {
                            items = smaller;
                            DecrementCount();
                            return true;
                        }
                        removed = true;
                        continue;
                    }
                    else
                    {
                        smaller[i] = items[i];
                        if (i == count - 1)
                        {
                            return false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else  // IF REMOVED IS TRUE
                {                  
                    smaller[i - 1] = items[i];               
                    if (i == count - 1)
                    {
                        items = smaller;
                        DecrementCount();
                        return true;
                    }

                }
            }

            return false;
        }

        private void DecrementCount()
        {
            count -= 1;
        }



        // ZIP
        public CustomList<T> Zip( CustomList<T> newList) // SOME KIND OF TYPE RESTRICTION??
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
                    result += items[i] + "]";
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
            foreach(T item in items)
            {
                if (item.Equals(check))
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
            CustomList<T> one = new CustomList<T>();
            CustomList<T> two = new CustomList<T>();
            one = listOne;
            two = listTwo;


            foreach (T item in listOne)
            {

                if ((two.Contains(item)) == true)
                {

                    two.Remove(item);
                }
                else
                {
                    sum.Add(item);
                }

            }


            return sum;

 
        
        }










    }


}
