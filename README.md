# `CustomList<T>`



# Operator Override (" - ")

"-" override [static ovverride method in the `CustomList<T>` class ]

---
## Description: 

   > When using the "-" operator on two generic `CustomList<T> `Objects of the same type,
    Any values found in the second list will be removed from the first list.
   > Each ocurance of a value in the second list is seperately removed from the first,
    so that if there are multiple instances of the value in the first object and only
    one in the second, the first occurence ONLY will be removed.
> The call can also be made in succession so that(list1 - list2 - list3 - list4)  will calculate as:

       

     ((list1 - list2) - list3)) - list4
---
## Syntax: 

 Calling the method: assuming both arguements are of type `CustomList<T>`
```
arguement1 - arguement2 = reult;
```
 arguement1 is the first instance in line ("arguement1 - arguement2")


---
## Parameters: 


| Element | Description |
| ------- | ------------|
| arguement1       | `CustomList<T> `Object (start) |
| arguement2     | `CustomList<T>` Object (to be substracted) |
| "-"  | Operator that calls the function|


  >  T   Takes 2 List Objects of the same type
 The first is stated "object1" followed by "-" then the 
"object2"
> object1 - object2 (= the new list)
---
## Return type:

>Returns a **new List** of the same type as the list inputs;
---
## Example: 

    CustomList<T> one = new CustomList<T>(){1,2,2,3,3,5,5};
    CustomList<T> two = new CustomList<T>(){2,2,3,4,5};

    CustomList<T> result = one - two ;

> the result will be {1,3,5}



```
public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
{
    CustomList<T> newList = new CustomList<T>();
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
            newList.Add(item);
        }
    }
    return newList;

}

```