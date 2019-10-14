using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private T[] items;
        public int Count { get; }
        public int Capacity { get; }
        private T[] newArray;
        public int capacity = 4;
        public int count = 0;
        public string stringWord;


        public CustomList()
        {
            items = new T[4];
            newArray = new T[capacity];
        }

        public void Add(T itemToAdd)
        {
            items[count] = itemToAdd;  //adding the item passing through from unit test to the empty items array
            count++; //increasing the count of the array by 1
            if (count == capacity)  //if count(number of elements is equal to the capacity - 4 in this case and by Microsoft default, go into to scope of if statement
            {
                newArray = items; //initialize the new empty array that was added under member variables and instantiated under the constructor. make it equal to existing items array
                capacity = capacity * 2; //capacity is currenty only 4, so we will double the newArray capacity to 8 so we can fit more elements if necessary
                items = new T[capacity]; //making the items array equal to a new generic(T) with a capacity now of 8
                for (int i = 0; i < count; i++) //if 0 is less than the count of the array(# of elements in array) then enter the for loop
                {
                    items[i] = newArray[i]; //iterate through the two arrays and copy the elements in newArray to items array
                }
                items[count] = itemToAdd; //return the items array. allow unit test to find items at an index, count etc.
            }
        }
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++) //going to loop through the existing items array as long as 0 is less than the count of the array
            {
                if (itemToRemove.Equals(items[i])) //if while iterating through the array it lands on the number that we passed in to be removed, enter the scope of this statment
                {
                    count--; //decrement the count - elements in the array by 1
                    for (int j = i; j < (count + 1); j++) //rearranging the array as if an element was removed
                    {
                        items[j] = items[j + 1];
                    }
                }
                else
                {
                    items[i] = items[i]; //if the 'if' statement isn't true, it will come to this and loop back up to the if statement until it finds the equal item
                }
            }
        }
        public override string ToString()
        {
            string stringWord = ""; //declaring a new variable with an empty string
            for (int i = 0; i < count; i++) //iterating through the elements in the items array
            {
                string word = items[i].ToString(); //declaring a new variable 'word' and making it equal to the items index we are currently at and converting it to a string
                if (i == count) // if current index of items array is equal to the count, enter the scope of the if statement, otherwise go to next line
                {
                    stringWord += word + ""; //once the index equals the count of the array, it will add the fully concatenated string to the stringWord variable and return it 
                    break;
                }
                stringWord += word + ""; // add the first string at current index of array to the empty string 'stringWord' variable to start building string
            }
            return stringWord; //returns the fully concatentated string word once it has iterated over the entire array
        }



        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator +(CustomList<T> l1, CustomList<T> l2)
        {
            CustomList<T> combinedLists = new CustomList<T>(); //declaring a new list that will combine the two lists passing through
            if (l1.count != 0) //if the count of list 1 is not equal to 0, start the for loop
            {
                for (int i = 0; i < l1.count; i++) //loop through the list checking each iteration of it
                {
                    combinedLists.Add(l1[i]); //adding the value at each index to the combined lists variable until all values have been added
                }
            }
            if(l2.count != 0) //if the count of list 2 is not equal to 0, start the for loop
            {
                for(int i = 0; i < l2.count; i++) //loop through the list checking each iteration of it
                {
                    combinedLists.Add(l2[i]); //adding the value at each index to the combined lists variable until all values have been added
                }
            }
            return combinedLists; //returning the combined list with both list values 
        }
        public static CustomList<T> operator -(CustomList<T> l1, CustomList<T> l2)
        {
            CustomList<T> removingItem = new CustomList<T>();
            CustomList<T> combinedArray = new CustomList<T>();
            for(int i = 0; i < l1.count; i++)
            {
                for(int j = 0; j < l2.count; j++)
                {
                    if (l1[i].Equals(l2[j]))
                    {
                        removingItem.Add(l1[i]);
                        j = l1.count;
                    }
                }
            }
            return combinedArray;
        }

        public T this[int index]
        {
            get
            {
                if(index > Count - 1)
                {

                }
                return items[index];
            }
            set { items[index] = value; }
        }
    }
}
