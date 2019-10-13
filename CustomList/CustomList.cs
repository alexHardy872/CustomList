using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T> where T : IComparable
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



        public void Sort<T>(int start, int end) where T: IComparable // // Custom Sort similar to HEAP SORT
        {
            if (count % 2 != 0 && end == start + 1)
            {
                
            }
            else if (count % 2 == 0 && end == start)
            {

            }
            else
            {
                LargestValueToLastIndex<T>(start, end);
                SmallestValueToFirstIndex<T>(start, end);
                Sort<T>(start + 1, end - 1);
            }
        }

        public void LargestValueToLastIndex<T>(int start, int end) where T: IComparable
        {
            {
                for (int i = start; i < end; i++)
                {
                    if (i == end - 1)
                    {
                        break;
                    }
                    if (items[i].CompareTo(items[end-1]) >= 0)
                    {
                        AddAt(items[i], end);
                        RemoveAt(i);  
                    }
                }   
            }
        }

        public void SmallestValueToFirstIndex<T>(int start, int end) where T : IComparable
        {
            for (int i = end - 1; i > start; i--)
            {
                if (items[i].CompareTo(items[start]) < 0)
                {
                    AddAt(items[i], start);
                    RemoveAt(i + 1);
                }
            }
        }


        public int BinarySearch<T>(T target) where T : IComparable
        {
            int index = DivideAndConquer<T>(target, count / 2, -1 );
            return index;
        }


        public int DivideAndConquer<T>(T target, int index, int lastIndex) where T : IComparable
        {
            if (target.CompareTo(items[index]) == 0)
            {
                return index;
            }
            // CHECK FOR INSERTABLE SPACE
            if (Math.Abs(index - lastIndex) == 1 || index == lastIndex)
            {
               if (items[index].CompareTo(target) < 0 && items[lastIndex].CompareTo(target) > 0)
                {
                    return lastIndex;
                }
                else if (items[index].CompareTo(target) > 0 && items[lastIndex].CompareTo(target) < 0)
                {
                    return index;
                }
                else
                {
                   
                    if (target.CompareTo(items[index]) > 0)
                    {
                        return index + 1;
                    }
                    else
                    {
                        return index;
                    }
                }
            }
           
           
            if (target.CompareTo(items[index]) < 0)  // target less than midpoint
            {
                if (lastIndex > -1)
                {
                    if (target.CompareTo(items[lastIndex]) > 0)
                    {
                        return DivideAndConquer<T>(target, (index + lastIndex) / 2, lastIndex);
                    }
                } 
                return DivideAndConquer<T>(target, index/2, index);
            }
            else  //target more than midpoint
            {
                if (lastIndex > -1)
                {
                    if (target.CompareTo(items[lastIndex]) < 0)
                    {
                        return DivideAndConquer<T>(target, ((index + lastIndex) / 2), lastIndex);
                    }
                }
               
                return DivideAndConquer<T>(target, (index + count)/2, index);
            }

            
        }







    }


}
