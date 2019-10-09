# CustomList


DESCRIPTION (+ and - operator overloads)
////////////////////////////////////////////////////////////////////////////////////////////

____________________________________________________________________________________________
"+" override


Description: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    When using the "+" operator on two generic CustomList Objects of the same type,
    they will be combined inline to return a new list of the same type.

    Can also be called in succession:

        list1 + list2 + list3 + list4

        will calculate as:

            ((list1 + list2) + list3)) + list4

Syntax: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

    Calling the methode:

    List1 + List2 = Reult;

   // input1 is the first instance in line ("input1 + input2")

    public satic ListClassName<T> operator + (ListClassName<T> input1 , ListClassName<T> input2)
    {
        ListClassName<T>  output = new ListClassName<T>;

        foreach (T x in input1)   // Uses foreach to add all of input1 to empty list
        {
            output.Add(x)  ;       // Uses Class methos Add to add x to new list
        }
                                    // once all of input1 is in, do the same for input2
        foreach (T x in input2)
        {
            output.Add(x);
        }

        return output;              // returns new list with all elements
    }

Parameters: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


    T   Takes 2 List Objects of the same type

        The first is stated "object1" followed by "+" then the "object2"

        object1 + object2 (= the new list)

Return type: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    Returns a new List of the same type as the list inputs;

Example: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    CustomList<T> one = new CustomList<T>(){1,2,3};
    CustomList<T> two = new CustomList<T>(){4,5,6};

    CustomList<T> result = one + two ;

    // the result will be {1,2,3,4,5,6}



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

___________________________________________________________________________________________
"-" override


Description: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    When using the "-" operator on two generic CustomList Objects of the same type,
    Any values found in the second list will be removed from the first list.

    Each ocurance of a value in the second list is seperately removed from the first,
    so that if there are multiple instances of the value in the first object and only
    one in the second, the first occurence ONLY will be removed.

      Can also be called in succession:

        list1 - list2 - list3 - list4

        will calculate as:

            ((list1 - list2) - list3)) - list4

Syntax: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

    Calling the methode:

    List1 - List2 = Reult;

   // input1 is the first instance in line ("input1 + input2")

    public satic ListClassName<T> operator - (ListClassName<T> input1 , ListClassName<T> input2)
    {
            ListClassName<T> result = new ListClassName<T>(); 
            ListClassName<T> temp = new ListClassName<T>();
            
            temp = input2;                         // Assign listTwos value a temperary list 

            foreach (T item in input1)             // checks each value in first list
            {

                if ((temp.Contains(item)) == true)  // uses ListClass.Contain() to check if the 
                                                        value is in list2
                {

                    temp.Remove(item);              // When substracted, Remove value from temp
                }
                else                                // if not the value is added to the result list
                {
                    result.Add(item);
                }
            }
            return result;                          // returns new (list1 - values from list2)
  
        }
    }

Parameters: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


    T   Takes 2 List Objects of the same type

        The first is stated "object1" followed by "-" then the "object2"

        object1 - object2 (= the new list)

Return type: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    Returns a new List of the same type as the list inputs;

Example: - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    CustomList<T> one = new CustomList<T>(){1,2,2,3,3,5,5};
    CustomList<T> two = new CustomList<T>(){2,2,3,4,5};

    CustomList<T> result = one - two ;

    // the result will be {1,3,5}



     public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> sum = new CustomList<T>();
            CustomList<T> two = new CustomList<T>();
            
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

________________________________________________________________________________________________