﻿using System;
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
