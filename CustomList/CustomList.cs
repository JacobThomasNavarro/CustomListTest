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

        public CustomList()
        {
            items = new T[4];
        }

        public void Add(T itemToAdd)
        {
           
        }
        public int this[int index]
        {
            get
            {
                return [index];
            }
        }
    }
}
