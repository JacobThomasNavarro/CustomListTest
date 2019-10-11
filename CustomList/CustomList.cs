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
            items[count] = itemToAdd;
            count++;
            if (count == capacity)
            {
                newArray = items;
                capacity = capacity * 2;
                items = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = newArray[i];
                }
                items[count] = itemToAdd;
            }
        }
        public void Remove(T itemToRemove)
        {
            for(int i = 0; i < count; i++)
            {
                if (itemToRemove.Equals(items[i]))
                {
                    count--;
                    for (int j = i; j < (count + 1); j++)
                    {
                        items[j] = items[j + 1];
                    }
                }
                else
                {
                    items[i] = items[i];
                }
            }
        }
        public override string ToString()
        {
            string stringWord = "";
            for(int i = 0; i < count; i++)
            {
                string word = items[i].ToString();
                if(i == count)
                {
                    stringWord += word + "";
                    break;
                }
                stringWord += word + "";
            }
            return stringWord;
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
